using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using IB.CSharpApiClient.Example.Domain;
using IB.CSharpApiClient.Example.Domain.ValueObject;
using IB.CSharpApiClient.Extensions;
using IB.CSharpApiClient.Messages;
using IBApi;

namespace IB.CSharpApiClient.Example.Infrastructure
{
    public class RealTimeDataProviderExample : ApiClient, IRealTimeDataProviderExample
    {
        public event EventHandler<Level1MarketDataEventArgs> MarketData;
        private readonly Dictionary<string, int> _requestIdsBySymbol;
        private readonly Dictionary<int, Level1MarketDataEventArgs> _lastsByRequestId;

        public RealTimeDataProviderExample(IApiClientMessageDispatcher apiClientMessageDispatcher,
            EReaderSignal readerMonitorSignal,
            EClientSocket clientSocket): base(apiClientMessageDispatcher, readerMonitorSignal, clientSocket, ApiClientDefault.DefaultTimeoutMs)
        {
            _requestIdsBySymbol = new Dictionary<string, int>();
            _lastsByRequestId = new Dictionary<int, Level1MarketDataEventArgs>();
            TickPrice += EventDispatcherOnTickPrice;
            TickSize += EventDispatcherOnTickSize;
        }

        public Task<Scanner[]> GetScannerAsync(ScannerSubscription scannerSubscription, List<TagValue> scannerSubscriptionOptions = null)
        {
            var ct = new CancellationTokenSource(DefaultTimeoutMs);
            var res = new TaskCompletionSource<Scanner[]>();
            ct.Token.Register(() => res.TrySetCanceled(), false);

            var reqId = new Random(DateTime.Now.Millisecond).Next();
            scannerSubscriptionOptions = scannerSubscriptionOptions ?? new List<TagValue>();
            var scanners = new List<Scanner>();

            void ScannerHandler(ScannerMessage scannerMessage)
            {
                if (scannerMessage.RequestId != reqId) return;
                scanners.Add(new Scanner(scannerMessage.Rank, scannerMessage.ContractDetails, scannerMessage.Distance, scannerMessage.Benchmark, scannerMessage.Projection, scannerMessage.LegsStr));
            }

            void ScannerEndHandler(ScannerEndMessage scannerEndMessage)
            {
                if (scannerEndMessage.RequestId != reqId) return;
                res.SetResult(scanners.ToArray());
            }

            Scanner += ScannerHandler;
            ScannerEnd += ScannerEndHandler;
            
            ClientSocket.reqScannerSubscription(reqId, scannerSubscription, scannerSubscriptionOptions);

            res.Task.ContinueWith(x =>
            {
                ClientSocket.cancelScannerSubscription(reqId);
                Scanner -= ScannerHandler;
                ScannerEnd -= ScannerEndHandler;
                ct.Dispose();

            }, TaskContinuationOptions.None);

            return res.Task;
        }

        public void SubscribeMarketData(string symbol)
        {
            lock (_requestIdsBySymbol)
            {
                if (_requestIdsBySymbol.ContainsKey(symbol)) return;
                var contract = new Contract
                {
                    Symbol = symbol.ToUpper(),
                    SecType = "STK",
                    Currency = "USD",
                    Exchange = "SMART"
                };
                var requestId = new Random().Next();
                ClientSocket.reqMktData(requestId, contract, string.Empty, false, false, null);
                _requestIdsBySymbol.Add(symbol, requestId);
            }
        }

        public void UnsubscribeMarketData(string symbol)
        {
            lock (_requestIdsBySymbol)
            {
                if (_requestIdsBySymbol.TryGetValue(symbol, out var requestId))
                {
                    ClientSocket.cancelMktData(requestId);
                    _requestIdsBySymbol.Remove(symbol);
                    _lastsByRequestId.Remove(requestId);
                }
            }
        }

        private void EventDispatcherOnTickPrice(TickPriceMessage tickPriceMessage)
        {
            if (!_lastsByRequestId.TryGetValue(tickPriceMessage.RequestId, out var last))
            {
                last = new Level1MarketDataEventArgs();
                _lastsByRequestId.Add(tickPriceMessage.RequestId, last);
            }

            last.UpdateValues(tickPriceMessage.Field, tickPriceMessage.Price);
            MarketData.RaiseEvent(this, last.ShallowCopy());
        }

        private void EventDispatcherOnTickSize(TickSizeMessage tickSizeMessage)
        {
            if (!_lastsByRequestId.TryGetValue(tickSizeMessage.RequestId, out var last))
            {
                last = new Level1MarketDataEventArgs();
                _lastsByRequestId.Add(tickSizeMessage.RequestId, last);
            }

            last.UpdateValues(tickSizeMessage.Field, tickSizeMessage.Size);
            MarketData.RaiseEvent(this, last.ShallowCopy());
        }
    }
}