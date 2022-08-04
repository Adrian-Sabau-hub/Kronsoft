using Lists.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    internal class Program
    {
        
            List<Customer> customers = new();
            customers.Add(new Customer());
            //List<Customer> customers = CreateCustomers();            

            #region linq
            var duplicates = customers.Concat(customers).OrderBy(c => c.Name);
            List<string> names = duplicates.Select(c => c.Name).Distinct().ToList();
            Console.WriteLine(names[0]);
            #endregion linq
        

        private static List<Customer> CreateCustomers()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer
                {
                    Name = "Customer One",
                    ContractDate = DateTime.Today.AddYears(-1)
                },
                new Customer
                {
                    Name = "Customer Two",
                    ContractDate = DateTime.Today.AddYears(-2)
                },
                new Customer
                {
                    Name = "Customer Three",
                    ContractDate = DateTime.Today.AddYears(-3)
                },
                new Customer
                {
                    Name = "Customer Four",
                    ContractDate = DateTime.Today.AddYears(-4)
                },
                new Customer
                {
                    Name = "Customer Five",
                    ContractDate = DateTime.Today.AddYears(-5)
                },
            };

            return customers;
        }
    }
}
