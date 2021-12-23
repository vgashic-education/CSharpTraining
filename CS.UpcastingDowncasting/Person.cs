using System;

namespace CS.UpcastingDowncasting
{
    public class Person : Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
