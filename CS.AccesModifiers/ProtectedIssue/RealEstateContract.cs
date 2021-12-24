namespace CS.AccesModifiers.ProtectedIssue
{
    public class RealEstateContract : ContractBase
    {
        public RealEstateContract() : base()
        {
            SetTaxRate();
            CalculateCategory();
        }

        public string Address { get; set; }

        public string ParcelNo { get; set; }
    }
}
