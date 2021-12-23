using System;

namespace CS.ConstructorInheritance
{
    public class Car : Vehicle
    {
        public Car(decimal topSpeed)
            : base("Car", topSpeed)
        {
            Console.WriteLine("Car created");
        }

        public string Make { get; set; }
    }
}
