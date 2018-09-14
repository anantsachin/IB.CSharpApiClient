using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class NewsProvidersMessage
    {
        public NewsProvidersMessage(NewsProvider[] newsProviders)
        {
            NewsProviders = newsProviders;
        }

        public NewsProvider[] NewsProviders { get; }

        public override string ToString()
        {
            return $"{nameof(NewsProviders)}: {NewsProviders}";
        }
    }
}