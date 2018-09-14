namespace IB.CSharpApiClient.Messages
{
    public class AdvisorDataMessage
    {
        public AdvisorDataMessage(int faDataType, string data)
        {
            FaDataType = faDataType;
            Data = data;
        }

        public int FaDataType { get; }
        public string Data { get; }

        public override string ToString()
        {
            return $"{nameof(FaDataType)}: {FaDataType}, {nameof(Data)}: {Data}";
        }
    }
}