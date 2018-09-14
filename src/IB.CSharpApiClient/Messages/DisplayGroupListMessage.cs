namespace IB.CSharpApiClient.Messages
{
    public class DisplayGroupListMessage
    {
        public DisplayGroupListMessage(int reqId, string groups)
        {
            ReqId = reqId;
            Groups = groups;
        }

        public int ReqId { get; }
        public string Groups { get; }

        public override string ToString()
        {
            return $"{nameof(ReqId)}: {ReqId}, {nameof(Groups)}: {Groups}";
        }
    }
}