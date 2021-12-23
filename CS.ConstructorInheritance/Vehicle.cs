using System;

namespace CS.ConstructorInheritance
{
    public class Vehicle
    {
        public Vehicle(string name, decimal topSpeed)
        {
            _name = name;
            _topSpeed = topSpeed;

            Console.WriteLine("Vehicle created");
        }

        private decimal _topSpeed;
        public decimal TopSpeed => _topSpeed;

        private string _name;
        public string Name => _name;

    }
}
