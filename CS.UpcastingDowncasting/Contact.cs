namespace CS.UpcastingDowncasting
{
    public class Contact
    {
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $@"---
{Street}
{PostalCode} {City}
📞 {PhoneNumber}
📱 {Mobile}
📧 {Email}
---";
        }
    }
}
