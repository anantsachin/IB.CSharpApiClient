using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using IB.CSharpApiClient.Messages;
using IBApi;

namespace IB.CSharpApiClient
{
    public class ApiClient : IApiClient, IApiClientMessage
    {
        #region Message Events
        public event Action<AccountDownloadEndMessage> AccountDownloadEnd
        {
            add => _apiClientMessageDispatcher.AccountDownloadEnd += value;
            remove => _apiClientMessageDispatcher.AccountDownloadEnd -= value;
        }

        public event Action<AccountSummaryMessage> AccountSummary
        {
            add => _apiClientMessageDispatcher.AccountSummary += value;
            remove => _apiClientMessageDispatcher.AccountSummary -= value;
        }

        public event Action<AccountSummaryEndMessage> AccountSummaryEnd
        {
            add => _apiClientMessageDispatcher.AccountSummaryEnd += value;
            remove => _apiClientMessageDispatcher.AccountSummaryEnd -= value;
        }

        public event Action<AccountUpdateMultiMessage> AccountUpdateMulti
        {
            add => _apiClientMessageDispatcher.AccountUpdateMulti += value;
            remove => _apiClientMessageDispatcher.AccountUpdateMulti -= value;
        }

        public event Action<AccountUpdateMultiEndMessage> AccountUpdateMultiEnd
        {
            add => _apiClientMessageDispatcher.AccountUpdateMultiEnd += value;
            remove => _apiClientMessageDispatcher.AccountUpdateMultiEnd -= value;
        }

        public event Action<AccountValueMessage> AccountValue
        {
            add => _apiClientMessageDispatcher.AccountValue += value;
            remove => _apiClientMessageDispatcher.AccountValue -= value;
        }

        public event Action<AdvisorDataMessage> AdvisorData
        {
            add => _apiClientMessageDispatcher.AdvisorData += value;
            remove => _apiClientMessageDispatcher.AdvisorData -= value;
        }

        public event Action<BondContractDetailsMessage> BondContractDetails
        {
            add => _apiClientMessageDispatcher.BondContractDetails += value;
            remove => _apiClientMessageDispatcher.BondContractDetails -= value;
        }

        public event Action<CommissionReportMessage> CommissionReport
        {
            add => _apiClientMessageDispatcher.CommissionReport += value;
            remove => _apiClientMessageDispatcher.CommissionReport -= value;
        }

        public event Action ConnectionClosed
        {
            add => _apiClientMessageDispatcher.ConnectionClosed += value;
            remove => _apiClientMessageDispatcher.ConnectionClosed -= value;
        }

        public event Action<ConnectionStatusMessage> ConnectionStatus
        {
            add => _apiClientMessageDispatcher.ConnectionStatus += value;
            remove => _apiClientMessageDispatcher.ConnectionStatus -= value;
        }

        public event Action<ContractDetailsMessage> ContractDetails
        {
            add => _apiClientMessageDispatcher.ContractDetails += value;
            remove => _apiClientMessageDispatcher.ContractDetails -= value;
        }

        public event Action<ContractDetailsEndMessage> ContractDetailsEnd
        {
            add => _apiClientMessageDispatcher.ContractDetailsEnd += value;
            remove => _apiClientMessageDispatcher.ContractDetailsEnd -= value;
        }

        public event Action<DailyPnLMessage> DailyPnL
        {
            add => _apiClientMessageDispatcher.DailyPnL += value;
            remove => _apiClientMessageDispatcher.DailyPnL -= value;
        }

        public event Action<DailyPnLSingleMessage> DailyPnLSingle
        {
            add => _apiClientMessageDispatcher.DailyPnLSingle += value;
            remove => _apiClientMessageDispatcher.DailyPnLSingle -= value;
        }

        public event Action<DeepBookMessage> DeepBook
        {
            add => _apiClientMessageDispatcher.DeepBook += value;
            remove => _apiClientMessageDispatcher.DeepBook -= value;
        }

        public event Action<DeltaNeutralValidationMessage> DeltaNeutralValidation
        {
            add => _apiClientMessageDispatcher.DeltaNeutralValidation += value;
            remove => _apiClientMessageDispatcher.DeltaNeutralValidation -= value;
        }

        public event Action<ErrorMessage> Error
        {
            add => _apiClientMessageDispatcher.Error += value;
            remove => _apiClientMessageDispatcher.Error -= value;
        }

        public event Action<ExecutionMessage> Execution
        {
            add => _apiClientMessageDispatcher.Execution += value;
            remove => _apiClientMessageDispatcher.Execution -= value;
        }

        public event Action<ExecutionEndMessage> ExecutionEnd
        {
            add => _apiClientMessageDispatcher.ExecutionEnd += value;
            remove => _apiClientMessageDispatcher.ExecutionEnd -= value;
        }

        public event Action<FamilyCodesMessage> FamilyCodes
        {
            add => _apiClientMessageDispatcher.FamilyCodes += value;
            remove => _apiClientMessageDispatcher.FamilyCodes -= value;
        }

        public event Action<FundamentalsMessage> Fundamentals
        {
            add => _apiClientMessageDispatcher.Fundamentals += value;
            remove => _apiClientMessageDispatcher.Fundamentals -= value;
        }

        public event Action<HeadTimestampMessage> HeadTimestamp
        {
            add => _apiClientMessageDispatcher.HeadTimestamp += value;
            remove => _apiClientMessageDispatcher.HeadTimestamp -= value;
        }

        public event Action<HistogramDataMessage> HistogramData
        {
            add => _apiClientMessageDispatcher.HistogramData += value;
            remove => _apiClientMessageDispatcher.HistogramData -= value;
        }

        public event Action<HistoricalDataMessage> HistoricalData
        {
            add => _apiClientMessageDispatcher.HistoricalData += value;
            remove => _apiClientMessageDispatcher.HistoricalData -= value;
        }

        public event Action<HistoricalDataEndMessage> HistoricalDataEnd
        {
            add => _apiClientMessageDispatcher.HistoricalDataEnd += value;
            remove => _apiClientMessageDispatcher.HistoricalDataEnd -= value;
        }

        public event Action<HistoricalDataMessage> HistoricalDataUpdate
        {
            add => _apiClientMessageDispatcher.HistoricalDataUpdate += value;
            remove => _apiClientMessageDispatcher.HistoricalDataUpdate -= value;
        }

        public event Action<HistoricalNewsMessage> HistoricalNews
        {
            add => _apiClientMessageDispatcher.HistoricalNews += value;
            remove => _apiClientMessageDispatcher.HistoricalNews -= value;
        }

        public event Action<HistoricalNewsEndMessage> HistoricalNewsEnd
        {
            add => _apiClientMessageDispatcher.HistoricalNewsEnd += value;
            remove => _apiClientMessageDispatcher.HistoricalNewsEnd -= value;
        }

        public event Action<HistoricalTickMessage> HistoricalTick
        {
            add => _apiClientMessageDispatcher.HistoricalTick += value;
            remove => _apiClientMessageDispatcher.HistoricalTick -= value;
        }

        public event Action<HistoricalTickBidAskMessage> HistoricalTickBidAsk
        {
            add => _apiClientMessageDispatcher.HistoricalTickBidAsk += value;
            remove => _apiClientMessageDispatcher.HistoricalTickBidAsk -= value;
        }

        public event Action<HistoricalTickBidAskEndMessage> HistoricalTickBidAskEnd
        {
            add => _apiClientMessageDispatcher.HistoricalTickBidAskEnd += value;
            remove => _apiClientMessageDispatcher.HistoricalTickBidAskEnd -= value;
        }

        public event Action<HistoricalTickEndMessage> HistoricalTickEnd
        {
            add => _apiClientMessageDispatcher.HistoricalTickEnd += value;
            remove => _apiClientMessageDispatcher.HistoricalTickEnd -= value;
        }

        public event Action<HistoricalTickLastEventArgs> HistoricalTickLast
        {
            add => _apiClientMessageDispatcher.HistoricalTickLast += value;
            remove => _apiClientMessageDispatcher.HistoricalTickLast -= value;
        }

        public event Action<HistoricalTickLastEndEventArgs> HistoricalTickLastEnd
        {
            add => _apiClientMessageDispatcher.HistoricalTickLastEnd += value;
            remove => _apiClientMessageDispatcher.HistoricalTickLastEnd -= value;
        }

        public event Action<ManagedAccountsMessage> ManagedAccounts
        {
            add => _apiClientMessageDispatcher.ManagedAccounts += value;
            remove => _apiClientMessageDispatcher.ManagedAccounts -= value;
        }

        public event Action<MarketDataTypeMessage> MarketDataType
        {
            add => _apiClientMessageDispatcher.MarketDataType += value;
            remove => _apiClientMessageDispatcher.MarketDataType -= value;
        }

        public event Action<MarketRuleMessage> MarketRule
        {
            add => _apiClientMessageDispatcher.MarketRule += value;
            remove => _apiClientMessageDispatcher.MarketRule -= value;
        }

        public event Action<MktDepthExchangesMessage> MktDepthExchanges
        {
            add => _apiClientMessageDispatcher.MktDepthExchanges += value;
            remove => _apiClientMessageDispatcher.MktDepthExchanges -= value;
        }

        public event Action<NewsArticleMessage> NewsArticle
        {
            add => _apiClientMessageDispatcher.NewsArticle += value;
            remove => _apiClientMessageDispatcher.NewsArticle -= value;
        }

        public event Action<NewsProvidersMessage> NewsProviders
        {
            add => _apiClientMessageDispatcher.NewsProviders += value;
            remove => _apiClientMessageDispatcher.NewsProviders -= value;
        }

        public event Action<OpenOrderMessage> OpenOrder
        {
            add => _apiClientMessageDispatcher.OpenOrder += value;
            remove => _apiClientMessageDispatcher.OpenOrder -= value;
        }

        public event Action OpenOrderEnd
        {
            add => _apiClientMessageDispatcher.OpenOrderEnd += value;
            remove => _apiClientMessageDispatcher.OpenOrderEnd -= value;
        }

        public event Action<OrderStatusMessage> OrderStatus
        {
            add => _apiClientMessageDispatcher.OrderStatus += value;
            remove => _apiClientMessageDispatcher.OrderStatus -= value;
        }

        public event Action<PositionMessage> Position
        {
            add => _apiClientMessageDispatcher.Position += value;
            remove => _apiClientMessageDispatcher.Position -= value;
        }

        public event Action PositionEnd
        {
            add => _apiClientMessageDispatcher.PositionEnd += value;
            remove => _apiClientMessageDispatcher.PositionEnd -= value;
        }

        public event Action<PositionMultiMessage> PositionMulti
        {
            add => _apiClientMessageDispatcher.PositionMulti += value;
            remove => _apiClientMessageDispatcher.PositionMulti -= value;
        }

        public event Action<PositionMultiEndMessage> PositionMultiEnd
        {
            add => _apiClientMessageDispatcher.PositionMultiEnd += value;
            remove => _apiClientMessageDispatcher.PositionMultiEnd -= value;
        }

        public event Action<RealTimeBarMessage> RealTimeBar
        {
            add => _apiClientMessageDispatcher.RealTimeBar += value;
            remove => _apiClientMessageDispatcher.RealTimeBar -= value;
        }

        public event Action<ScannerMessage> Scanner
        {
            add => _apiClientMessageDispatcher.Scanner += value;
            remove => _apiClientMessageDispatcher.Scanner -= value;
        }

        public event Action<ScannerEndMessage> ScannerEnd
        {
            add => _apiClientMessageDispatcher.ScannerEnd += value;
            remove => _apiClientMessageDispatcher.ScannerEnd -= value;
        }

        public event Action<ScannerParametersMessage> ScannerParameters
        {
            add => _apiClientMessageDispatcher.ScannerParameters += value;
            remove => _apiClientMessageDispatcher.ScannerParameters -= value;
        }

        public event Action<SecurityDefinitionOptionParameterMessage> SecurityDefinitionOptionParameter
        {
            add => _apiClientMessageDispatcher.SecurityDefinitionOptionParameter += value;
            remove => _apiClientMessageDispatcher.SecurityDefinitionOptionParameter -= value;
        }

        public event Action<SecurityDefinitionOptionParameterEndMessage> SecurityDefinitionOptionParameterEnd
        {
            add => _apiClientMessageDispatcher.SecurityDefinitionOptionParameterEnd += value;
            remove => _apiClientMessageDispatcher.SecurityDefinitionOptionParameterEnd -= value;
        }

        public event Action<SoftDollarTiersMessage> SoftDollarTiers
        {
            add => _apiClientMessageDispatcher.SoftDollarTiers += value;
            remove => _apiClientMessageDispatcher.SoftDollarTiers -= value;
        }

        public event Action<SymbolSamplesMessage> SymbolSamples
        {
            add => _apiClientMessageDispatcher.SymbolSamples += value;
            remove => _apiClientMessageDispatcher.SymbolSamples -= value;
        }

        public event Action<TickByTickAllLastMessage> TickByTickAllLast
        {
            add => _apiClientMessageDispatcher.TickByTickAllLast += value;
            remove => _apiClientMessageDispatcher.TickByTickAllLast -= value;
        }

        public event Action<TickByTickBidAskMessage> TickByTickBidAsk
        {
            add => _apiClientMessageDispatcher.TickByTickBidAsk += value;
            remove => _apiClientMessageDispatcher.TickByTickBidAsk -= value;
        }

        public event Action<TickByTickMidPointMessage> TickByTickMidPoint
        {
            add => _apiClientMessageDispatcher.TickByTickMidPoint += value;
            remove => _apiClientMessageDispatcher.TickByTickMidPoint -= value;
        }

        public event Action<TickEfpMessage> TickEfp
        {
            add => _apiClientMessageDispatcher.TickEfp += value;
            remove => _apiClientMessageDispatcher.TickEfp -= value;
        }

        public event Action<TickGenericMessage> TickGeneric
        {
            add => _apiClientMessageDispatcher.TickGeneric += value;
            remove => _apiClientMessageDispatcher.TickGeneric -= value;
        }

        public event Action<TickNewsMessage> TickNews
        {
            add => _apiClientMessageDispatcher.TickNews += value;
            remove => _apiClientMessageDispatcher.TickNews -= value;
        }

        public event Action<TickOptionMessage> TickOption
        {
            add => _apiClientMessageDispatcher.TickOption += value;
            remove => _apiClientMessageDispatcher.TickOption -= value;
        }

        public event Action<TickPriceMessage> TickPrice
        {
            add => _apiClientMessageDispatcher.TickPrice += value;
            remove => _apiClientMessageDispatcher.TickPrice -= value;
        }

        public event Action<TickReqParamsMessage> TickReqParams
        {
            add => _apiClientMessageDispatcher.TickReqParams += value;
            remove => _apiClientMessageDispatcher.TickReqParams -= value;
        }

        public event Action<TickSizeMessage> TickSize
        {
            add => _apiClientMessageDispatcher.TickSize += value;
            remove => _apiClientMessageDispatcher.TickSize -= value;
        }

        public event Action<TickSnapshotEndMessage> TickSnapshotEnd
        {
            add => _apiClientMessageDispatcher.TickSnapshotEnd += value;
            remove => _apiClientMessageDispatcher.TickSnapshotEnd -= value;
        }

        public event Action<TickStringMessage> TickString
        {
            add => _apiClientMessageDispatcher.TickString += value;
            remove => _apiClientMessageDispatcher.TickString -= value;
        }

        public event Action<TimeMessage> Time
        {
            add => _apiClientMessageDispatcher.Time += value;
            remove => _apiClientMessageDispatcher.Time -= value;
        }

        public event Action<UpdateAccountTimeMessage> UpdateAccountTime
        {
            add => _apiClientMessageDispatcher.UpdateAccountTime += value;
            remove => _apiClientMessageDispatcher.UpdateAccountTime -= value;
        }

        public event Action<UpdatePortfolioMessage> UpdatePortfolio
        {
            add => _apiClientMessageDispatcher.UpdatePortfolio += value;
            remove => _apiClientMessageDispatcher.UpdatePortfolio -= value;
        }

        public event Action ConnectAck
        {
            add => _apiClientMessageDispatcher.ConnectAck += value;
            remove => _apiClientMessageDispatcher.ConnectAck -= value;
        }

        public event Action<UpdateNewsBulletinMessage> UpdateNewsBulletin
        {
            add => _apiClientMessageDispatcher.UpdateNewsBulletin += value;
            remove => _apiClientMessageDispatcher.UpdateNewsBulletin -= value;
        }

        public event Action<VerifyMessageApiMessage> VerifyMessageApi
        {
            add => _apiClientMessageDispatcher.VerifyMessageApi += value;
            remove => _apiClientMessageDispatcher.VerifyMessageApi -= value;
        }

        public event Action<VerifyCompletedMessage> VerifyCompleted
        {
            add => _apiClientMessageDispatcher.VerifyCompleted += value;
            remove => _apiClientMessageDispatcher.VerifyCompleted -= value;
        }

        public event Action<VerifyAndAuthMessageApiMessage> VerifyAndAuthMessageApi
        {
            add => _apiClientMessageDispatcher.VerifyAndAuthMessageApi += value;
            remove => _apiClientMessageDispatcher.VerifyAndAuthMessageApi -= value;
        }

        public event Action<VerifyAndAuthCompletedMessage> VerifyAndAuthCompleted
        {
            add => _apiClientMessageDispatcher.VerifyAndAuthCompleted += value;
            remove => _apiClientMessageDispatcher.VerifyAndAuthCompleted -= value;
        }

        public event Action<DisplayGroupListMessage> DisplayGroupList
        {
            add => _apiClientMessageDispatcher.DisplayGroupList += value;
            remove => _apiClientMessageDispatcher.DisplayGroupList -= value;
        }

        public event Action<DisplayGroupUpdatedMessage> DisplayGroupUpdated
        {
            add => _apiClientMessageDispatcher.DisplayGroupUpdated += value;
            remove => _apiClientMessageDispatcher.DisplayGroupUpdated -= value;
        }

        public event Action<SmartComponentsMessage> SmartComponents
        {
            add => _apiClientMessageDispatcher.SmartComponents += value;
            remove => _apiClientMessageDispatcher.SmartComponents -= value;
        }

        public event Action<RerouteRequestMessage> RerouteMktDataRequest
        {
            add => _apiClientMessageDispatcher.RerouteMktDataRequest += value;
            remove => _apiClientMessageDispatcher.RerouteMktDataRequest -= value;
        }

        public event Action<RerouteRequestMessage> RerouteMktDepthRequest
        {
            add => _apiClientMessageDispatcher.RerouteMktDepthRequest += value;
            remove => _apiClientMessageDispatcher.RerouteMktDepthRequest -= value;
        }
        #endregion

        private readonly EReaderSignal _readerMonitorSignal;
        private readonly IApiClientMessageDispatcher _apiClientMessageDispatcher;
        private readonly object _mutex = new object();

        protected readonly EClientSocket ClientSocket;
        protected readonly int DefaultTimeoutMs;

        private int _nextOrderId = 0;
        public int NextOrderId
        {
            get
            {
                lock (_mutex)
                {
                    var nextOrderId = _nextOrderId;
                    _nextOrderId++;
                    return nextOrderId;
                }
            }
        }

        public ApiClient(
            IApiClientMessageDispatcher apiClientMessageDispatcher,
            EReaderSignal readerMonitorSignal,
            EClientSocket clientSocket,
            int defaultTimeoutMs)
        {
            DefaultTimeoutMs = defaultTimeoutMs;
            _apiClientMessageDispatcher = apiClientMessageDispatcher;
            _readerMonitorSignal = readerMonitorSignal;
            ClientSocket = clientSocket;

            ConnectAck += MessageDispatcherOnConnectAck;
            ConnectionStatus += MessageDispatcherOnConnectionStatus;
        }

        public void Connect(string host, int port, int clientId)
        {
            try
            {
                ClientSocket.eConnect(host, port, clientId);

                var reader = new EReader(ClientSocket, _readerMonitorSignal);

                reader.Start();

                new Thread(() =>
                {
                    while (ClientSocket.IsConnected())
                    {
                        _readerMonitorSignal.waitForSignal();
                        reader.processMsgs();
                    }
                })
                { IsBackground = true }.Start();
            }
            catch (Exception e)
            {
                throw;
            }

            // block until receiving a valid order id.
            while (_nextOrderId <= 0) { }
        }

        public Task ConnectAsync(string host, int port, int clientId)
        {
            var ct = new CancellationTokenSource(DefaultTimeoutMs);
            var res = new TaskCompletionSource<object>();
            ct.Token.Register(() => res.TrySetCanceled(), false);

            void ConnectAck()
            {
                // block until receiving a valid order id.
                while (_nextOrderId <= 0) { }

                res.SetResult(null);
            };

            this.ConnectAck += ConnectAck;
            Connect(host, port, clientId);

            res.Task.ContinueWith(x =>
            {
                this.ConnectAck -= ConnectAck;
                ct.Dispose();
            }, TaskContinuationOptions.None);

            return res.Task;
        }

        public void Disconnect()
        {
            try
            {
                ClientSocket.eDisconnect();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        #region ApiClient Commands
        public void calculateImpliedVolatility(int reqId, Contract contract, double optionPrice, double underPrice, List<TagValue> impliedVolatilityOptions)
        {
            ClientSocket.calculateImpliedVolatility(reqId, contract, optionPrice, underPrice, impliedVolatilityOptions);
        }

        public void calculateOptionPrice(int reqId, Contract contract, double volatility, double underPrice, List<TagValue> optionPriceOptions)
        {
            ClientSocket.calculateOptionPrice(reqId, contract, volatility, underPrice, optionPriceOptions);
        }

        public void cancelAccountSummary(int reqId)
        {
            ClientSocket.cancelAccountSummary(reqId);
        }

        public void cancelAccountUpdatesMulti(int requestId)
        {
            ClientSocket.cancelAccountUpdatesMulti(requestId);
        }

        public void cancelCalculateImpliedVolatility(int reqId)
        {
            ClientSocket.cancelCalculateImpliedVolatility(reqId);
        }

        public void cancelCalculateOptionPrice(int reqId)
        {
            ClientSocket.cancelCalculateOptionPrice(reqId);
        }

        public void cancelFundamentalData(int reqId)
        {
            ClientSocket.cancelFundamentalData(reqId);
        }

        public void cancelHeadTimestamp(int tickerId)
        {
            ClientSocket.cancelHeadTimestamp(tickerId);
        }

        public void cancelHistogramData(int tickerId)
        {
            ClientSocket.cancelHistogramData(tickerId);
        }

        public void cancelHistoricalData(int reqId)
        {
            ClientSocket.cancelHistoricalData(reqId);
        }

        public void cancelMktData(int tickerId)
        {
            ClientSocket.cancelMktData(tickerId);
        }

        public void cancelMktDepth(int tickerId)
        {
            ClientSocket.cancelMktDepth(tickerId);
        }

        public void cancelNewsBulletin()
        {
            ClientSocket.cancelNewsBulletin();
        }

        public void cancelOrder(int orderId)
        {
            ClientSocket.cancelOrder(orderId);
        }

        public void cancelPnL(int reqId)
        {
            ClientSocket.cancelPnL(reqId);
        }

        public void cancelPnLSingle(int reqId)
        {
            ClientSocket.cancelPnLSingle(reqId);
        }

        public void cancelPositions()
        {
            ClientSocket.cancelPositions();
        }

        public void cancelPositionsMulti(int requestId)
        {
            ClientSocket.cancelPositionsMulti(requestId);
        }

        public void cancelRealTimeBars(int tickerId)
        {
            ClientSocket.cancelRealTimeBars(tickerId);
        }

        public void cancelScannerSubscription(int tickerId)
        {
            ClientSocket.cancelScannerSubscription(tickerId);
        }

        public void cancelTickByTickData(int requestId)
        {
            ClientSocket.cancelTickByTickData(requestId);
        }

        public void Close()
        {
            ClientSocket.Close();
        }

        public void exerciseOptions(int tickerId, Contract contract, int exerciseAction, int exerciseQuantity, string account, int ovrd)
        {
            ClientSocket.exerciseOptions(tickerId, contract, exerciseAction, exerciseQuantity, account, ovrd);
        }

        public bool IsConnected()
        {
            return ClientSocket.IsConnected();
        }

        public void placeOrder(int id, Contract contract, Order order)
        {
            ClientSocket.placeOrder(id, contract, order);
        }

        public void queryDisplayGroups(int requestId)
        {
            ClientSocket.queryDisplayGroups(requestId);
        }

        public void replaceFA(int faDataType, string xml)
        {
            ClientSocket.replaceFA(faDataType, xml);
        }

        public void reqAccountSummary(int reqId, string @group, string tags)
        {
            ClientSocket.reqAccountSummary(reqId, @group, tags);
        }

        public void reqAccountUpdates(bool subscribe, string acctCode)
        {
            ClientSocket.reqAccountUpdates(subscribe, acctCode);
        }

        public void reqAccountUpdatesMulti(int requestId, string account, string modelCode, bool ledgerAndNLV)
        {
            ClientSocket.reqAccountUpdatesMulti(requestId, account, modelCode, ledgerAndNLV);
        }

        public void reqAllOpenOrders()
        {
            ClientSocket.reqAllOpenOrders();
        }

        public void reqAutoOpenOrders(bool autoBind)
        {
            ClientSocket.reqAutoOpenOrders(autoBind);
        }

        public void reqContractDetails(int reqId, Contract contract)
        {
            ClientSocket.reqContractDetails(reqId, contract);
        }

        public void reqCurrentTime()
        {
            ClientSocket.reqCurrentTime();
        }

        public void reqExecutions(int reqId, ExecutionFilter filter)
        {
            ClientSocket.reqExecutions(reqId, filter);
        }

        public void reqFamilyCodes()
        {
            ClientSocket.reqFamilyCodes();
        }

        public void reqFundamentalData(int reqId, Contract contract, string reportType, List<TagValue> fundamentalDataOptions)
        {
            ClientSocket.reqFundamentalData(reqId, contract, reportType, fundamentalDataOptions);
        }

        public void reqGlobalCancel()
        {
            ClientSocket.reqGlobalCancel();
        }

        public void reqHeadTimestamp(int tickerId, Contract contract, string whatToShow, int useRTH, int formatDate)
        {
            ClientSocket.reqHeadTimestamp(tickerId, contract, whatToShow, useRTH, formatDate);
        }

        public void reqHistogramData(int tickerId, Contract contract, bool useRTH, string period)
        {
            ClientSocket.reqHistogramData(tickerId, contract, useRTH, period);
        }

        public void reqHistoricalData(int tickerId, Contract contract, string endDateTime, string durationString,
            string barSizeSetting, string whatToShow, int useRTH, int formatDate, bool keepUpToDate, List<TagValue> chartOptions)
        {
            ClientSocket.reqHistoricalData(tickerId, contract, endDateTime, durationString, barSizeSetting, whatToShow,
                useRTH, formatDate, keepUpToDate, chartOptions);
        }

        public void reqHistoricalNews(int requestId, int conId, string providerCodes, string startDateTime, string endDateTime,
            int totalResults, List<TagValue> historicalNewsOptions)
        {
            ClientSocket.reqHistoricalNews(requestId, conId, providerCodes, startDateTime, endDateTime, totalResults,
                historicalNewsOptions);
        }

        public void reqHistoricalTicks(int reqId, Contract contract, string startDateTime, string endDateTime, int numberOfTicks,
            string whatToShow, int useRth, bool ignoreSize, List<TagValue> miscOptions)
        {
            ClientSocket.reqHistoricalTicks(reqId, contract, startDateTime, endDateTime, numberOfTicks, whatToShow, useRth, ignoreSize, miscOptions);
        }

        public void reqIds(int numIds)
        {
            ClientSocket.reqIds(numIds);
        }

        public void reqManagedAccts()
        {
            ClientSocket.reqManagedAccts();
        }

        public void reqMarketDataType(int marketDataType)
        {
            ClientSocket.reqMarketDataType(marketDataType);
        }

        public void reqMarketDepth(int tickerId, Contract contract, int numRows, List<TagValue> mktDepthOptions)
        {
            ClientSocket.reqMarketDepth(tickerId, contract, numRows, mktDepthOptions);
        }

        public void reqMarketRule(int marketRuleId)
        {
            ClientSocket.reqMarketRule(marketRuleId);
        }

        public void reqMatchingSymbols(int reqId, string pattern)
        {
            ClientSocket.reqMatchingSymbols(reqId, pattern);
        }

        public void reqMktData(int tickerId, Contract contract, string genericTickList, bool snapshot, bool regulatorySnaphsot, List<TagValue> mktDataOptions)
        {
            ClientSocket.reqMktData(tickerId, contract, genericTickList, snapshot, regulatorySnaphsot, mktDataOptions);
        }

        public void reqMktDepthExchanges()
        {
            ClientSocket.reqMktDepthExchanges();
        }

        public void reqNewsArticle(int requestId, string providerCode, string articleId, List<TagValue> newsArticleOptions)
        {
            ClientSocket.reqNewsArticle(requestId, providerCode, articleId, newsArticleOptions);
        }

        public void reqNewsBulletins(bool allMessages)
        {
            ClientSocket.reqNewsBulletins(allMessages);
        }

        public void reqNewsProviders()
        {
            ClientSocket.reqNewsProviders();
        }

        public void reqOpenOrders()
        {
            ClientSocket.reqOpenOrders();
        }

        public void reqPnL(int reqId, string account, string modelCode)
        {
            ClientSocket.reqPnL(reqId, account, modelCode);
        }

        public void reqPnLSingle(int reqId, string account, string modelCode, int conId)
        {
            ClientSocket.reqPnLSingle(reqId, account, modelCode, conId);
        }

        public void reqPositions()
        {
            ClientSocket.reqPositions();
        }

        public void reqPositionsMulti(int requestId, string account, string modelCode)
        {
            ClientSocket.reqPositionsMulti(requestId, account, modelCode);
        }

        public void reqRealTimeBars(int tickerId, Contract contract, int barSize, string whatToShow, bool useRTH, List<TagValue> realTimeBarsOptions)
        {
            ClientSocket.reqRealTimeBars(tickerId, contract, barSize, whatToShow, useRTH, realTimeBarsOptions);
        }

        public void reqScannerParameters()
        {
            ClientSocket.reqScannerParameters();
        }

        public void reqScannerSubscription(int reqId, ScannerSubscription subscription, List<TagValue> scannerSubscriptionOptions)
        {
            ClientSocket.reqScannerSubscription(reqId, subscription, scannerSubscriptionOptions);
        }

        public void reqSecDefOptParams(int reqId, string underlyingSymbol, string futFopExchange, string underlyingSecType, int underlyingConId)
        {
            ClientSocket.reqSecDefOptParams(reqId, underlyingSymbol, futFopExchange, underlyingSecType, underlyingConId);
        }

        public void reqSmartComponents(int reqId, string bboExchange)
        {
            ClientSocket.reqSmartComponents(reqId, bboExchange);
        }

        public void reqSoftDollarTiers(int reqId)
        {
            ClientSocket.reqSoftDollarTiers(reqId);
        }

        public void reqTickByTickData(int requestId, Contract contract, string tickType)
        {
            ClientSocket.reqTickByTickData(requestId, contract, tickType);
        }

        public void requestFA(int faDataType)
        {
            ClientSocket.requestFA(faDataType);
        }

        public void SetConnectOptions(string connectOptions)
        {
            ClientSocket.SetConnectOptions(connectOptions);
        }

        public void setServerLogLevel(int logLevel)
        {
            ClientSocket.setServerLogLevel(logLevel);
        }

        public void startApi()
        {
            ClientSocket.startApi();
        }

        public void subscribeToGroupEvents(int requestId, int groupId)
        {
            ClientSocket.subscribeToGroupEvents(requestId, groupId);
        }

        public void unsubscribeFromGroupEvents(int requestId)
        {
            ClientSocket.unsubscribeFromGroupEvents(requestId);
        }

        public void updateDisplayGroup(int requestId, string contractInfo)
        {
            ClientSocket.updateDisplayGroup(requestId, contractInfo);
        }

        public void verifyAndAuthMessage(string apiData, string xyzResponse)
        {
            ClientSocket.verifyAndAuthMessage(apiData, xyzResponse);
        }

        public void verifyAndAuthRequest(string apiName, string apiVersion, string opaqueIsvKey)
        {
            ClientSocket.verifyAndAuthRequest(apiName, apiVersion, opaqueIsvKey);
        }

        public void verifyMessage(string apiData)
        {
            ClientSocket.verifyMessage(apiData);
        }

        public void verifyRequest(string apiName, string apiVersion)
        {
            ClientSocket.verifyRequest(apiName, apiVersion);
        }
        #endregion

        private void MessageDispatcherOnConnectAck()
        {
            if (ClientSocket.AsyncEConnect)
                ClientSocket.startApi();
        }

        private void MessageDispatcherOnConnectionStatus(ConnectionStatusMessage connectionStatusEventArgs)
        {
            _nextOrderId = connectionStatusEventArgs.NextValidOrderId;
        }
    }
}