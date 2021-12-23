using CS.Shared;
using System;

namespace CS.AccesModifiers.Encapsulation
{
    public class Contract
    {
        private readonly Guid _id;
        private readonly string _description;
        private readonly decimal _value;
        
        private ContractStatus _status;
        private DateTime? _activationDate;
        private Invoice _activationInvoice;

        public Contract(string description, decimal value)
        {
            _id = Guid.NewGuid();
            _description = description;
            _value = value;

            _status = ContractStatus.Inactive;
            _activationDate = null;
            _activationInvoice = null;
        }

        public Guid ID => _id;

        public string Description => _description;

        public decimal Value => _value;

        public DateTime? ActivationDate => _activationDate;

        public ContractStatus Status => _status;

        public Invoice ActivationInvoice => _activationInvoice;

        /// <summary>
        /// Activates contract
        /// </summary>
        public void Activate()
        {
            if (_status == ContractStatus.Active)
            {
                throw new Exception("Contract is already activated");
            }

            var today = DateTime.Now;

            _activationDate = today;
            _status = ContractStatus.Active;

            var invoice = new Invoice($"{Description} (contract {ID})", Value);
            AddActivationInvoice(invoice);
        }


        public void ChangeStatus(ContractStatus newStatus)
        {
            #region new status validations

            if ((int)newStatus - (int)_status != 1)
            {
                throw new Exception($"Cannot change status from {_status} to {newStatus}");
            }

            if (_activationDate != null && newStatus == ContractStatus.Inactive)
            {
                throw new Exception($"Cannot set status to {newStatus} (activation date is not null)");
            }
            
            #endregion

            _status = newStatus;
        }


        private void AddActivationInvoice(Invoice invoice)
        {
            _activationInvoice = invoice;
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
