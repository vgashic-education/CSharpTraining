using System;

namespace CS.AccesModifiers.Encapsulation
{
    public class Invoice
    {
        private readonly Guid _id;
        private readonly string _description;
        private readonly decimal _totalAmount;
        private readonly DateTime _invoiceDate;

        public Invoice(string description, decimal totalAmount)
        {
            _id = Guid.NewGuid();
            _description = description;
            _invoiceDate = DateTime.Now;
            _totalAmount = totalAmount;
        }

        public Guid ID => _id;

        public string Description => _description;

        public DateTime InvoiceDate => _invoiceDate;

        public decimal TotalAmount => _totalAmount;


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
