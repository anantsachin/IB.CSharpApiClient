namespace IB.CSharpApiClient.Messages
{
    public class NewsArticleMessage
    {
        public NewsArticleMessage(int requestId, int articleType, string articleText)
        {
            RequestId = requestId;
            ArticleType = articleType;
            ArticleText = articleText;
        }

        public int RequestId { get; }
        public int ArticleType { get; }
        public string ArticleText { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(ArticleType)}: {ArticleType}, {nameof(ArticleText)}: {ArticleText}";
        }
    }
}