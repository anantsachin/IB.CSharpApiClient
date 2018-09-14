namespace IB.CSharpApiClient.Messages
{
    public class ScannerParametersMessage
    {
        public ScannerParametersMessage(string data)
        {
            XmlData = data;
        }

        public string XmlData { get; }

        public override string ToString()
        {
            return $"{nameof(XmlData)}: {XmlData}";
        }
    }
}