using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StoreAppDBContext.Models;

namespace DemoStoreAppDB
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Task1: Get a database to print orders with details such as product
                       Get a database to print customer orders with content
                       Get a database to print store orders with content
                Task2: 
             
            */
           

            
             // Creates a scope for the using statement
            using (DemoStoreAppDBContext customercontext = new DemoStoreAppDBContext())
            {
                var customers = customercontext.Customers.FromSqlRaw("Select * From Customers").ToList();
                int count = 0;
                foreach (var v in customers)
                {
                   Console.WriteLine($"{++count} - { v.FirstName} { v.LastName}");

                }



                #region
                //cus c3 = new cus();
                //c3.FirstName = "Gordon";
                //c3.LastName = "Heth";

                //context.Add(c3);
                //context.SaveChanges();

                //var ncus = context.Customers.FromSqlRaw("Select * From Customers Where FirstName = 'Gordon'").FirstOrDefault();

                //if("Gordon" != null)
                //{
                //Console.WriteLine($"The new customer is {ncus.FirstName} {ncus.LastName}");

                //}
                #endregion
            }//EoUsing
        }//EoM
    }//EoC
}//EoN
