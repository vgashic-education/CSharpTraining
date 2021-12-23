using System;

namespace CS.UpcastingDowncasting
{
    public abstract class Customer
    {
        public Guid Id { get; set; }

        public string FullName { get; set; }

        public string RegistrationNumber { get; set; }

        public Contact Contact { get; set; }
    }
}
