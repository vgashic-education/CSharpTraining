using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.AccesModifiers
{
    public class Contract
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        
        // Customer je internal
        // Contract je public
        // Ako pokusamo instancirati Contract u nekom drugom projektu,
        // necemo uspeti jer je tip jednog od property-ja deklarisan kao internal
        // tj. ne vidi se van svog projekta (assembly-ja)
        public Customer Customer { get; set; }
    }

    internal class Customer
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
    }

}
