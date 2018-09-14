namespace IB.CSharpApiClient.Messages
{
    public class AccountDownloadEndMessage
    {
        public AccountDownloadEndMessage(string account)
        {
            Account = account;
        }

        public string Account { get; }

        public override string ToString()
        {
            return $"{nameof(Account)}: {Account}";
        }
    }
}