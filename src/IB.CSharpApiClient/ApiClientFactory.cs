using IBApi;

namespace IB.CSharpApiClient
{
    public static class ApiClientFactory
    {
        public static ApiClient CreateNew(int defaultTimeoutMs = ApiClientDefault.DefaultTimeoutMs)
        {
            var readerMonitorSignal = new EReaderMonitorSignal();
            var apiClientMessageDispatcher = new ApiClientMessageDispatcher();
            var clientSocket = new EClientSocket(apiClientMessageDispatcher, readerMonitorSignal);

            return new ApiClient(apiClientMessageDispatcher, readerMonitorSignal, clientSocket, defaultTimeoutMs);
        }
    }
}