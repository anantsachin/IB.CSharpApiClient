namespace IB.CSharpApiClient.Messages
{
    public class VerifyCompletedMessage
    {
        public VerifyCompletedMessage(bool isSuccessful, string errorText)
        {
            IsSuccessful = isSuccessful;
            ErrorText = errorText;
        }

        public bool IsSuccessful { get; }
        public string ErrorText { get; }

        public override string ToString()
        {
            return $"{nameof(ErrorText)}: {ErrorText}, {nameof(IsSuccessful)}: {IsSuccessful}";
        }
    }
}