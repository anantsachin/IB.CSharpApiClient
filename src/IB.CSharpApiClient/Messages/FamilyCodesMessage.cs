using IBApi;

namespace IB.CSharpApiClient.Messages
{
    public class FamilyCodesMessage
    {
        public FamilyCodesMessage(FamilyCode[] familyCodes)
        {
            FamilyCodes = familyCodes;
        }

        public FamilyCode[] FamilyCodes { get; }

        public override string ToString()
        {
            return $"{nameof(FamilyCodes)}: {FamilyCodes}";
        }
    }
}