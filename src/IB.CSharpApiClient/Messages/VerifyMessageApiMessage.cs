namespace IB.CSharpApiClient.Messages
{
    public class VerifyMessageApiMessage
    {
        public VerifyMessageApiMessage(string apiData)
        {
            ApiData = apiData;
        }

        public string ApiData { get; }

        public override string ToString()
        {
            return $"{nameof(ApiData)}: {ApiData}";
        }
    }
}