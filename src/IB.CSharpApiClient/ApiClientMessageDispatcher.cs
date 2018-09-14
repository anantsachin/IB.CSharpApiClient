using System;
using System.Collections.Generic;
using IB.CSharpApiClient.Messages;
using IBApi;

namespace IB.CSharpApiClient
{
    public class ApiClientMessageDispatcher : IApiClientMessageDispatcher
    {
        public event Action<AccountDownloadEndMessage> AccountDownloadEnd;
        public event Action<AccountSummaryMessage> AccountSummary;
        public event Action<AccountSummaryEndMessage> AccountSummaryEnd;
        public event Action<AccountUpdateMultiMessage> AccountUpdateMulti;
        public event Action<AccountUpdateMultiEndMessage> AccountUpdateMultiEnd;
        public event Action<AccountValueMessage> AccountValue;
        public event Action<AdvisorDataMessage> AdvisorData;
        public event Action<BondContractDetailsMessage> BondContractDetails;
        public event Action<CommissionReportMessage> CommissionReport;
        public event Action ConnectionClosed;
        public event Action<ConnectionStatusMessage> ConnectionStatus;
        public event Action<ContractDetailsMessage> ContractDetails;
        public event Action<ContractDetailsEndMessage> ContractDetailsEnd;
        public event Action<DailyPnLMessage> DailyPnL;
        public event Action<DailyPnLSingleMessage> DailyPnLSingle;
        public event Action<DeepBookMessage> DeepBook;
        public event Action<DeltaNeutralValidationMessage> DeltaNeutralValidation;
        public event Action<ErrorMessage> Error;
        public event Action<ExecutionMessage> Execution;
        public event Action<ExecutionEndMessage> ExecutionEnd;
        public event Action<FamilyCodesMessage> FamilyCodes;
        public event Action<FundamentalsMessage> Fundamentals;
        public event Action<HeadTimestampMessage> HeadTimestamp;
        public event Action<HistogramDataMessage> HistogramData;
        public event Action<HistoricalDataMessage> HistoricalData;
        public event Action<HistoricalDataEndMessage> HistoricalDataEnd;
        public event Action<HistoricalDataMessage> HistoricalDataUpdate;
        public event Action<HistoricalNewsMessage> HistoricalNews;
        public event Action<HistoricalNewsEndMessage> HistoricalNewsEnd;
        public event Action<HistoricalTickMessage> HistoricalTick;
        public event Action<HistoricalTickBidAskMessage> HistoricalTickBidAsk;
        public event Action<HistoricalTickBidAskEndMessage> HistoricalTickBidAskEnd;
        public event Action<HistoricalTickEndMessage> HistoricalTickEnd;
        public event Action<HistoricalTickLastEventArgs> HistoricalTickLast;
        public event Action<HistoricalTickLastEndEventArgs> HistoricalTickLastEnd;
        public event Action<ManagedAccountsMessage> ManagedAccounts;
        public event Action<MarketDataTypeMessage> MarketDataType;
        public event Action<MarketRuleMessage> MarketRule;
        public event Action<MktDepthExchangesMessage> MktDepthExchanges;
        public event Action<NewsArticleMessage> NewsArticle;
        public event Action<NewsProvidersMessage> NewsProviders;
        public event Action<OpenOrderMessage> OpenOrder;
        public event Action OpenOrderEnd;
        public event Action<OrderStatusMessage> OrderStatus;
        public event Action<PositionMessage> Position;
        public event Action PositionEnd;
        public event Action<PositionMultiMessage> PositionMulti;
        public event Action<PositionMultiEndMessage> PositionMultiEnd;
        public event Action<RealTimeBarMessage> RealTimeBar;
        public event Action<ScannerMessage> Scanner;
        public event Action<ScannerEndMessage> ScannerEnd;
        public event Action<ScannerParametersMessage> ScannerParameters;
        public event Action<SecurityDefinitionOptionParameterMessage> SecurityDefinitionOptionParameter;
        public event Action<SecurityDefinitionOptionParameterEndMessage> SecurityDefinitionOptionParameterEnd;
        public event Action<SoftDollarTiersMessage> SoftDollarTiers;
        public event Action<SymbolSamplesMessage> SymbolSamples;
        public event Action<TickByTickAllLastMessage> TickByTickAllLast;
        public event Action<TickByTickBidAskMessage> TickByTickBidAsk;
        public event Action<TickByTickMidPointMessage> TickByTickMidPoint;
        public event Action<TickEfpMessage> TickEfp;
        public event Action<TickGenericMessage> TickGeneric;
        public event Action<TickNewsMessage> TickNews;
        public event Action<TickOptionMessage> TickOption;
        public event Action<TickPriceMessage> TickPrice;
        public event Action<TickReqParamsMessage> TickReqParams;
        public event Action<TickSizeMessage> TickSize;
        public event Action<TickSnapshotEndMessage> TickSnapshotEnd;
        public event Action<TickStringMessage> TickString;
        public event Action<TimeMessage> Time;
        public event Action<UpdateAccountTimeMessage> UpdateAccountTime;
        public event Action<UpdatePortfolioMessage> UpdatePortfolio;
        public event Action ConnectAck;
        public event Action<UpdateNewsBulletinMessage> UpdateNewsBulletin;
        public event Action<VerifyMessageApiMessage> VerifyMessageApi;
        public event Action<VerifyCompletedMessage> VerifyCompleted;
        public event Action<VerifyAndAuthMessageApiMessage> VerifyAndAuthMessageApi;
        public event Action<VerifyAndAuthCompletedMessage> VerifyAndAuthCompleted;
        public event Action<DisplayGroupListMessage> DisplayGroupList;
        public event Action<DisplayGroupUpdatedMessage> DisplayGroupUpdated;
        public event Action<SmartComponentsMessage> SmartComponents;
        public event Action<RerouteRequestMessage> RerouteMktDataRequest;
        public event Action<RerouteRequestMessage> RerouteMktDepthRequest;

        #region Callbacks
        public void error(Exception e)
        {
            Error?.Invoke(new ErrorMessage(e));
        }

        public void error(string str)
        {
            Error?.Invoke(new ErrorMessage(str));
        }

        public void error(int id, int errorCode, string errorMsg)
        {
            Error?.Invoke(new ErrorMessage(id, errorCode, errorMsg));
        }

        public void currentTime(long time)
        {
            Time?.Invoke(new TimeMessage(time));
        }

        public void tickPrice(int tickerId, int field, double price, TickAttrib attribs)
        {
            TickPrice?.Invoke(new TickPriceMessage(tickerId, field, price, attribs));
        }

        public void tickSize(int tickerId, int field, int size)
        {
            TickSize?.Invoke(new TickSizeMessage(tickerId, field, size));
        }

        public void tickString(int tickerId, int field, string value)
        {
            TickString?.Invoke(new TickStringMessage(tickerId, field, value));
        }

        public void tickGeneric(int tickerId, int field, double value)
        {
            TickGeneric?.Invoke(new TickGenericMessage(tickerId, field, value));
        }

        public void tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture,
            int holdDays, string futureLastTradeDate, double dividendImpact, double dividendsToLastTradeDate)
        {
            TickEfp?.Invoke(new TickEfpMessage(tickerId, tickType, basisPoints, formattedBasisPoints, impliedFuture, holdDays, futureLastTradeDate, dividendImpact, dividendsToLastTradeDate));
        }

        public void deltaNeutralValidation(int reqId, UnderComp underComp)
        {
            DeltaNeutralValidation?.Invoke(new DeltaNeutralValidationMessage(reqId, underComp));
        }

        public void tickOptionComputation(int tickerId, int field, double impliedVolatility, double delta, double optPrice,
            double pvDividend, double gamma, double vega, double theta, double undPrice)
        {
            TickOption?.Invoke(new TickOptionMessage(tickerId, field, impliedVolatility, delta, optPrice, pvDividend, gamma, vega, theta, undPrice));
        }

        public void tickSnapshotEnd(int tickerId)
        {
            TickSnapshotEnd?.Invoke(new TickSnapshotEndMessage(tickerId));
        }

        public void nextValidId(int orderId)
        {
            ConnectionStatus?.Invoke(new ConnectionStatusMessage(true, orderId));
        }

        public void managedAccounts(string accountsList)
        {
            ManagedAccounts?.Invoke(new ManagedAccountsMessage(accountsList));
        }

        public void connectionClosed()
        {
            ConnectionClosed?.Invoke();
        }

        public void accountSummary(int reqId, string account, string tag, string value, string currency)
        {
            AccountSummary?.Invoke(new AccountSummaryMessage(reqId, account, tag, value, currency));
        }

        public void accountSummaryEnd(int reqId)
        {
            AccountSummaryEnd?.Invoke(new AccountSummaryEndMessage(reqId));
        }

        public void bondContractDetails(int reqId, ContractDetails contract)
        {
            BondContractDetails?.Invoke(new BondContractDetailsMessage(reqId, contract));
        }

        public void updateAccountValue(string key, string value, string currency, string accountName)
        {
            AccountValue?.Invoke(new AccountValueMessage(key, value, currency, accountName));
        }

        public void updatePortfolio(Contract contract, double position, double marketPrice, double marketValue, double averageCost,
            double unrealizedPNL, double realizedPNL, string accountName)
        {
            UpdatePortfolio?.Invoke(new UpdatePortfolioMessage(contract, position, marketPrice, marketValue, averageCost, unrealizedPNL, realizedPNL, accountName));
        }

        public void updateAccountTime(string timestamp)
        {
            UpdateAccountTime?.Invoke(new UpdateAccountTimeMessage(timestamp));
        }

        public void accountDownloadEnd(string account)
        {
            AccountDownloadEnd?.Invoke(new AccountDownloadEndMessage(account));
        }

        public void orderStatus(int orderId, string status, double filled, double remaining, double avgFillPrice, int permId,
            int parentId, double lastFillPrice, int clientId, string whyHeld, double mktCapPrice)
        {
            OrderStatus?.Invoke(new OrderStatusMessage(orderId, status, filled, remaining, avgFillPrice, permId, parentId,
            lastFillPrice, clientId, whyHeld, mktCapPrice));
        }

        public void openOrder(int orderId, Contract contract, Order order, OrderState orderState)
        {
            OpenOrder?.Invoke(new OpenOrderMessage(orderId, contract, order, orderState));
        }

        public void openOrderEnd()
        {
            OpenOrderEnd?.Invoke();
        }

        public void contractDetails(int reqId, ContractDetails contractDetails)
        {
            ContractDetails?.Invoke(new ContractDetailsMessage(reqId, contractDetails));
        }

        public void contractDetailsEnd(int reqId)
        {
            ContractDetailsEnd?.Invoke(new ContractDetailsEndMessage(reqId));
        }

        public void execDetails(int reqId, Contract contract, Execution execution)
        {
            Execution?.Invoke(new ExecutionMessage(reqId, contract, execution));
        }

        public void execDetailsEnd(int reqId)
        {
            ExecutionEnd?.Invoke(new ExecutionEndMessage(reqId));
        }

        public void commissionReport(CommissionReport commissionReport)
        {
            CommissionReport?.Invoke(new CommissionReportMessage(commissionReport));
        }

        public void fundamentalData(int reqId, string data)
        {
            Fundamentals?.Invoke(new FundamentalsMessage(reqId, data));
        }

        public void historicalData(int reqId, Bar bar)
        {
            HistoricalData?.Invoke(new HistoricalDataMessage(reqId, bar));
        }

        public void historicalDataUpdate(int reqId, Bar bar)
        {
            HistoricalDataUpdate?.Invoke(new HistoricalDataMessage(reqId, bar));
        }

        public void historicalDataEnd(int reqId, string start, string end)
        {
            HistoricalDataEnd?.Invoke(new HistoricalDataEndMessage(reqId, start, end));
        }

        public void marketDataType(int reqId, int marketDataType)
        {
            MarketDataType?.Invoke(new MarketDataTypeMessage(reqId, marketDataType));
        }

        public void updateMktDepth(int tickerId, int position, int operation, int side, double price, int size)
        {
            DeepBook?.Invoke(new DeepBookMessage(tickerId, position, operation, side, price, size, string.Empty));
        }

        public void updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side, double price, int size)
        {
            DeepBook?.Invoke(new DeepBookMessage(tickerId, position, operation, side, price, size, marketMaker));
        }

        public void updateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            UpdateNewsBulletin?.Invoke(new UpdateNewsBulletinMessage(msgId, msgType, message, origExchange));
        }

        public void position(string account, Contract contract, double pos, double avgCost)
        {
            Position?.Invoke(new PositionMessage(account, contract, pos, avgCost));
        }

        public void positionEnd()
        {
            PositionEnd?.Invoke();
        }

        public void realtimeBar(int reqId, long time, double open, double high, double low, double close, long volume, double WAP,
            int count)
        {
            RealTimeBar?.Invoke(new RealTimeBarMessage(reqId, time, open, high, low, close, volume, WAP, count));
        }

        public void scannerParameters(string xml)
        {
            ScannerParameters?.Invoke(new ScannerParametersMessage(xml));
        }

        public void scannerData(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark,
            string projection, string legsStr)
        {
            Scanner?.Invoke(new ScannerMessage(reqId, rank, contractDetails, distance, benchmark, projection, legsStr));
        }

        public void scannerDataEnd(int reqId)
        {
            ScannerEnd?.Invoke(new ScannerEndMessage(reqId));
        }

        public void receiveFA(int faDataType, string faXmlData)
        {
            AdvisorData?.Invoke(new AdvisorDataMessage(faDataType, faXmlData));
        }

        public void verifyMessageAPI(string apiData)
        {
            VerifyMessageApi?.Invoke(new VerifyMessageApiMessage(apiData));
        }

        public void verifyCompleted(bool isSuccessful, string errorText)
        {
            VerifyCompleted?.Invoke(new VerifyCompletedMessage(isSuccessful, errorText));
        }

        public void verifyAndAuthMessageAPI(string apiData, string xyzChallenge)
        {
            VerifyAndAuthMessageApi?.Invoke(new VerifyAndAuthMessageApiMessage(apiData, xyzChallenge));
        }

        public void verifyAndAuthCompleted(bool isSuccessful, string errorText)
        {
            VerifyAndAuthCompleted?.Invoke(new VerifyAndAuthCompletedMessage(isSuccessful, errorText));
        }

        public void displayGroupList(int reqId, string groups)
        {
            DisplayGroupList?.Invoke(new DisplayGroupListMessage(reqId, groups));
        }

        public void displayGroupUpdated(int reqId, string contractInfo)
        {
            DisplayGroupUpdated?.Invoke(new DisplayGroupUpdatedMessage(reqId, contractInfo));
        }

        public void connectAck()
        {
            ConnectAck?.Invoke();
        }

        public void positionMulti(int requestId, string account, string modelCode, Contract contract, double pos, double avgCost)
        {
            PositionMulti?.Invoke(new PositionMultiMessage(requestId, account, modelCode, contract, pos, avgCost));
        }

        public void positionMultiEnd(int requestId)
        {
            PositionMultiEnd?.Invoke(new PositionMultiEndMessage(requestId));
        }

        public void accountUpdateMulti(int requestId, string account, string modelCode, string key, string value, string currency)
        {
            AccountUpdateMulti?.Invoke(new AccountUpdateMultiMessage(requestId, account, modelCode, key, value, currency));
        }

        public void accountUpdateMultiEnd(int requestId)
        {
            AccountUpdateMultiEnd?.Invoke(new AccountUpdateMultiEndMessage(requestId));
        }

        public void securityDefinitionOptionParameter(int reqId, string exchange, int underlyingConId, string tradingClass,
            string multiplier, HashSet<string> expirations, HashSet<double> strikes)
        {
            SecurityDefinitionOptionParameter?.Invoke(new SecurityDefinitionOptionParameterMessage(reqId, exchange, underlyingConId, tradingClass,
                multiplier, expirations, strikes));
        }

        public void securityDefinitionOptionParameterEnd(int reqId)
        {
            SecurityDefinitionOptionParameterEnd?.Invoke(new SecurityDefinitionOptionParameterEndMessage(reqId));
        }

        public void softDollarTiers(int reqId, SoftDollarTier[] tiers)
        {
            SoftDollarTiers?.Invoke(new SoftDollarTiersMessage(reqId, tiers));
        }

        public void familyCodes(FamilyCode[] familyCodes)
        {
            FamilyCodes?.Invoke(new FamilyCodesMessage(familyCodes));
        }

        public void symbolSamples(int reqId, ContractDescription[] contractDescriptions)
        {
            SymbolSamples?.Invoke(new SymbolSamplesMessage(reqId, contractDescriptions));
        }

        public void mktDepthExchanges(DepthMktDataDescription[] depthMktDataDescriptions)
        {
            MktDepthExchanges?.Invoke(new MktDepthExchangesMessage(depthMktDataDescriptions));
        }

        public void tickNews(int tickerId, long timeStamp, string providerCode, string articleId, string headline, string extraData)
        {
            TickNews?.Invoke(new TickNewsMessage(tickerId, timeStamp, providerCode, articleId, headline, extraData));
        }

        public void smartComponents(int reqId, Dictionary<int, KeyValuePair<string, char>> theMap)
        {
            SmartComponents?.Invoke(new SmartComponentsMessage(reqId, theMap));
        }

        public void tickReqParams(int tickerId, double minTick, string bboExchange, int snapshotPermissions)
        {
            TickReqParams?.Invoke(new TickReqParamsMessage(tickerId, minTick, bboExchange, snapshotPermissions));
        }

        public void newsProviders(NewsProvider[] newsProviders)
        {
            NewsProviders?.Invoke(new NewsProvidersMessage(newsProviders));
        }

        public void newsArticle(int requestId, int articleType, string articleText)
        {
            NewsArticle?.Invoke(new NewsArticleMessage(requestId, articleType, articleText));
        }

        public void historicalNews(int requestId, string time, string providerCode, string articleId, string headline)
        {
            HistoricalNews?.Invoke(new HistoricalNewsMessage(requestId, time, providerCode, articleId, headline));
        }

        public void historicalNewsEnd(int requestId, bool hasMore)
        {
            HistoricalNewsEnd?.Invoke(new HistoricalNewsEndMessage(requestId, hasMore));
        }

        public void headTimestamp(int reqId, string headTimestamp)
        {
            HeadTimestamp?.Invoke(new HeadTimestampMessage(reqId, headTimestamp));
        }

        public void histogramData(int reqId, HistogramEntry[] data)
        {
            HistogramData?.Invoke(new HistogramDataMessage(reqId, data));
        }

        public void rerouteMktDataReq(int reqId, int conId, string exchange)
        {
            RerouteMktDataRequest?.Invoke(new RerouteRequestMessage(reqId, conId, exchange));
        }

        public void rerouteMktDepthReq(int reqId, int conId, string exchange)
        {
            RerouteMktDepthRequest?.Invoke(new RerouteRequestMessage(reqId, conId, exchange));
        }

        public void marketRule(int marketRuleId, PriceIncrement[] priceIncrements)
        {
            MarketRule?.Invoke(new MarketRuleMessage(marketRuleId, priceIncrements));
        }

        public void pnl(int reqId, double dailyPnL, double unrealizedPnL, double realizedPnL)
        {
            DailyPnL?.Invoke(new DailyPnLMessage(reqId, dailyPnL, unrealizedPnL, realizedPnL));
        }

        public void pnlSingle(int reqId, int pos, double dailyPnL, double unrealizedPnL, double realizedPnL, double value)
        {
            DailyPnLSingle?.Invoke(new DailyPnLSingleMessage(reqId, pos, dailyPnL, unrealizedPnL, realizedPnL, value));
        }

        public void historicalTicks(int reqId, HistoricalTick[] ticks, bool done)
        {
            foreach (var tick in ticks)
            {
                HistoricalTick?.Invoke(new HistoricalTickMessage(reqId, tick.Time, tick.Price, tick.Size));
            }

            if (done)
            {
                HistoricalTickEnd?.Invoke(new HistoricalTickEndMessage(reqId));
            }
        }

        public void historicalTicksBidAsk(int reqId, HistoricalTickBidAsk[] ticks, bool done)
        {
            foreach (var tick in ticks)
            {
                HistoricalTickBidAsk?.Invoke(new HistoricalTickBidAskMessage(reqId, tick.Time, tick.Mask, tick.PriceBid, tick.PriceAsk, tick.SizeBid, tick.SizeAsk));
            }

            if (done)
            {
                HistoricalTickBidAskEnd?.Invoke(new HistoricalTickBidAskEndMessage(reqId));
            }
        }

        public void historicalTicksLast(int reqId, HistoricalTickLast[] ticks, bool done)
        {
            foreach (var tick in ticks)
            {
                HistoricalTickLast?.Invoke(new HistoricalTickLastEventArgs(reqId, tick.Time, tick.Mask, tick.Price, tick.Size, tick.Exchange, tick.SpecialConditions));
            }

            if (done)
            {
                HistoricalTickLastEnd?.Invoke(new HistoricalTickLastEndEventArgs(reqId));
            }
        }

        public void tickByTickAllLast(int reqId, int tickType, long time, double price, int size, TickAttrib attribs, string exchange,
            string specialConditions)
        {
            TickByTickAllLast?.Invoke(new TickByTickAllLastMessage(reqId, tickType, time, price, size, attribs, exchange, specialConditions));
        }

        public void tickByTickBidAsk(int reqId, long time, double bidPrice, double askPrice, int bidSize, int askSize,
            TickAttrib attribs)
        {
            TickByTickBidAsk?.Invoke(new TickByTickBidAskMessage(reqId, time, bidPrice, askPrice, bidSize, askSize, attribs));
        }

        public void tickByTickMidPoint(int reqId, long time, double midPoint)
        {
            TickByTickMidPoint?.Invoke(new TickByTickMidPointMessage(reqId, time, midPoint));
        }
        #endregion
    }
}
