using CS.Shared;
using System;

namespace CS.AccesModifiers.AllPublic
{
    public class Contract
    {
        public Contract(string description, decimal value)
        {
            ID = Guid.NewGuid();
            Description = description;
            Value = value;

            Status = ContractStatus.Inactive;
            ActivationDate = null;
        }

        public Guid ID { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }

        public DateTime? ActivationDate { get; set; }

        public ContractStatus Status { get; set; }

        public Invoice ActivationInvoice { get; set; }

        /// <summary>
        /// Activates contract
        /// </summary>
        public void Activate()
        {
            if (Status == ContractStatus.Active)
            {
                throw new Exception("Contract is already activated");
            }

            var today = DateTime.Now;

            ActivationDate = today;
            Status = ContractStatus.Active;

            var invoice = new Invoice($"{Description} (contract {ID})", Value);
            AddActivationInvoice(invoice);
        }


        public void AddActivationInvoice(Invoice invoice)
        {
            ActivationInvoice = invoice;
        }



        #region override

        public override string ToString()
        {
            return $@"--------------
ID: {ID}
Description: {Description}
Value: {Value:N2}
Status: {Status}
Activation date: {(ActivationDate != null ? ActivationDate.Value.ToString("dd.MM.yyyy") : "N/A")}
ActivationInvoice:
{ActivationInvoice?.ToString() ?? "N/A"}
--------------
";
        }

        #endregion
    }
}
