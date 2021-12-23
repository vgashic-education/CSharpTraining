using System;

namespace CS.AccesModifiers.AllPublic
{
    public class Invoice
    {
        public Invoice(string description, decimal totalAmount)
        {
            ID = Guid.NewGuid();
            Description = description;
            InvoiceDate = DateTime.Now;
            TotalAmount = totalAmount;
        }

        public Guid ID { get; set; }

        public string Description { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal TotalAmount { get; set; }


        #region override

        public override string ToString()
        {
            return $@"    >> ID: {ID}
    >> Description: {Description}
    >> InvoiceDate: {InvoiceDate:dd.MM.yyyy}
    >> TotalAmount: {TotalAmount:N2}";
        }

        #endregion
    }
}
