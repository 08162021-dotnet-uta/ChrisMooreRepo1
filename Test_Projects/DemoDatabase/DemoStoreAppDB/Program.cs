using System;

namespace DemoStoreAppDB
{
    class Program
    {
        static void Main(string[] args)
        {
           Customer c1 = new Customer();
           c1.Fname = "Chrisssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss";
           c1.Lname = "Joseph";

           Customer c2 = new Customer("Chris","Moore");

           Console.WriteLine($"The names are {c1.Fname} {c1.Lname}, {c2.Fname} {c2.Lname}");
        }
    }
}
