using System;
using System.Collections.Generic;

namespace CS.UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            foreach (var customer in Helper.GetMockPersons())
            {
                customers.Add((Customer)customer);
            }

            foreach (var customer in Helper.GetMockCompanies())
            {
                customers.Add((Customer)customer);
            }

            PrintAddresses(customers);
            //PrintCustomerData(customers, true);
        }


        private static void PrintAddresses(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FullName);
                Console.WriteLine(customer.Contact);
            }
        }


        private static void PrintCustomerData(List<Customer> customers, bool hideSensitiveData)
        {
            foreach (var customer in customers)
            {
                // downcast to derived type
                // if cast is unsuccessful, object will be null
                var person = customer as Person;
                var company = customer as Company;

                if (person != null)
                {
                    Console.WriteLine($"Name: {person.FirstName} {(hideSensitiveData ? "*****" : person.LastName)}");
                    Console.WriteLine($"Registration No: {(hideSensitiveData ? "*************" : person.RegistrationNumber)}");
                    Console.WriteLine($"Date of Birth: {(hideSensitiveData ? "**.**" : person.DateOfBirth.ToString("dd.MM"))}.{person.DateOfBirth.Year}");
                    Console.WriteLine(hideSensitiveData ? "Contact data unavailable" : person.Contact);
                }

                if (company != null)
                {
                    Console.WriteLine($"Name: {company.FullName}");
                    Console.WriteLine($"Registration No: {company.RegistrationNumber}");
                    Console.WriteLine($"TaxId: {company.TaxId}");
                    Console.WriteLine($"Number of employees: {company.NumberOfEmployees}");
                    Console.WriteLine(company.Contact);
                }

                Console.WriteLine("--------------------------------");
            }
        }
    }
}
