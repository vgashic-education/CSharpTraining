using System;

namespace CS.AccesModifiers.ProtectedIssue
{
    public abstract class ContractBase
    {
        public ContractBase()
        {
            _id = Guid.NewGuid();
        }

        private Guid _id;
        public Guid Id => _id;

        private decimal _netValue;
        public decimal NetValue => _netValue;

        public decimal Value => _netValue * _taxRate / 100;

        private decimal _taxRate;
        public decimal TaxRate => _taxRate;

        protected string _category;
        public string Category => _category;

        public virtual void SetNetValue(decimal netValue)
        {
            _netValue = netValue;
        }

        protected virtual void SetTaxRate(decimal taxRate = 20m)
        {
            _taxRate = taxRate;
        }

        protected virtual void CalculateCategory()
        {
            var category = Value switch
            {
                < 10_000 => "category_1",
                > 10_000 and < 50_000 => "category_2",
                > 50_000 and < 100_000 => "category_3",
                _ => "vip"
            };

            _category = category;
        }
    }
}
