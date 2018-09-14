using System.Collections.Generic;

namespace IB.CSharpApiClient.Messages
{
    public class ManagedAccountsMessage
    {
        public ManagedAccountsMessage(string managedAccounts)
        {
            ManagedAccounts = new List<string>(managedAccounts.Split(','));
        }

        public IList<string> ManagedAccounts { get; }

        public override string ToString()
        {
            return $"{nameof(ManagedAccounts)}: {ManagedAccounts}";
        }
    }
}