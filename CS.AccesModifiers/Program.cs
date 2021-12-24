using System;
using CS.AccesModifiers;
using CS.Shared;

namespace CS.AccesModifiers
{
    internal class ProgramAllPublic
    {
        static void Main(string[] args)
        {
            UseAllPublic();

            //UseEncapsulation();

            //ProtectedIssue();
        }


        private static void UseAllPublic()
        {
            // create new contract
            var contract = new AllPublic.Contract("VW Beetle", 12_000);

            Console.WriteLine(contract);

            // activate contract
            contract.Activate();
            Console.WriteLine(contract);

            // change of activation invoice is possible
            var invoice = new AllPublic.Invoice("VW Golf", 15_000);
            contract.AddActivationInvoice(invoice);
            Console.WriteLine(contract);

            // can change status without check
            contract.Status = ContractStatus.Inactive;
            Console.WriteLine(contract);
        }


        private static void UseEncapsulation()
        {
            // create contract
            var contract = new Encapsulation.Contract("Ford Mustang", 55_000);
            Console.WriteLine(contract);

            // activate
            contract.Activate();
            Console.WriteLine(contract);

            // cannot change status without validation
            contract.ChangeStatus(ContractStatus.Inactive);

            // cannot change activation invoice
            var invoice = new Encapsulation.Invoice("Fixed invoice", 50_000);
            //contract.ActivationInvoice = invoice;
        }


        private static void ProtectedIssue()
        {
            var bigContract = new ProtectedIssue.RealEstateContract();
            bigContract.SetNetValue(120_000);
            Console.WriteLine($"Contract value: {bigContract.Value} EUR");
            
            if (bigContract.Category.ToLower() == "vip")
            {
                Console.WriteLine("Attention. VIP contract.");
            }
        }
    }


}
