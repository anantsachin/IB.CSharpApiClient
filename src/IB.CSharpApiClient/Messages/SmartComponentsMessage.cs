using System.Collections.Generic;

namespace IB.CSharpApiClient.Messages
{
    public class SmartComponentsMessage
    {
        public SmartComponentsMessage(int requestId, Dictionary<int, KeyValuePair<string, char>> values)
        {
            RequestId = requestId;
            Values = values;
        }

        public int RequestId { get; }
        public Dictionary<int, KeyValuePair<string, char>> Values { get; }

        public override string ToString()
        {
            return $"{nameof(RequestId)}: {RequestId}, {nameof(Values)}: {Values}";
        }
    }
}