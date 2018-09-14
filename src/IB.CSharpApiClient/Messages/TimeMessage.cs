namespace IB.CSharpApiClient.Messages
{
    public class TimeMessage
    {
        public TimeMessage(long time)
        {
            CurrentTime = time;
        }

        public long CurrentTime { get; }

        public override string ToString()
        {
            return $"{nameof(CurrentTime)}: {CurrentTime}";
        }
    }
}