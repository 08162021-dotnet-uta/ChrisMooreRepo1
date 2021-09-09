using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StoreAppDBContext.Models;
using cus = StoreAppDBContext.Models.Customer;

namespace DemoStoreAppDB
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Hello, please enter your name: ");
            Console.ReadLine();
            // Creates a scope for the using statement
            using (DemoStoreAppDBContext context = new DemoStoreAppDBContext())
            {
                // List<Customer> customers = context.Customers.FromSqlRaw<Customer>("SELECT * FROM Customers").ToList();

                var customers = context.Customers.FromSqlRaw("Select * From Customers").ToList();

                foreach(var v in customers)
                {
                    Console.WriteLine($"{ v.FirstName} { v.LastName}");
                }

                cus c3 = new cus();
                c3.FirstName = "Gordon";
                c3.LastName = "Heth";

                context.Add(c3);
                context.SaveChanges();

                //var ncus = context.Customers.FromSqlRaw("Select * From Customers Where FirstName = 'Gordon'").FirstOrDefault();

                //if("Gordon" != null)
                //{
                    //Console.WriteLine($"The new customer is {ncus.FirstName} {ncus.LastName}");

                //}

            }
        }
    }
}
