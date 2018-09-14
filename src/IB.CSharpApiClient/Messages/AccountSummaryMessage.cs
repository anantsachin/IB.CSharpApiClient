namespace IB.CSharpApiClient.Messages
{
    public class AccountSummaryMessage
    {
        public AccountSummaryMessage(int requestId, string account, string tag, string value, string currency)
        {
            RequestId = requestId;
            Account = account;
            Tag = tag;
            Value = value;
            Currency = currency;
        }

        public int RequestId { get; }
        public string Account { get; }
        public string Tag { get; }
        public string Value { get; }
        public string Currency { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(Account)}: {Account}, {nameof(Tag)}: {Tag}, {nameof(Value)}: {Value}, {nameof(Currency)}: {Currency}";
        }
    }
}