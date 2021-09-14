using System;

namespace Project1.WebStoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }//EoM
    }//EoP
}//EoN



// Todo Today
/*
 * 1. Register a new user (FirstName, LastName, Username, Password)
 * 
 * using(DemoContext _custcontex = new DemoContext)
 * {
 * 
 *      var customers = _custcontext.Customers.FromSqlRaw("SELECT * FROM CUSTOMERS").ToList();
 *      int count = 0;
        foreach(var v in customers)
        {
            Console.WriteLine($"{++count}-{v.FirstName}{v.LastName}");
        }
 * 
 * 
 * if(userInput == "1")
 * {
 *      //Instatiates the view model inside the statement
 *      ViewModelCustomer c = new ViewModelCustomer;
 * 
 *      //Give a Login Option
 *      Console.WriteLine($"Please enter your first name");
 *      string FirstName = Console.ReadLine();
 *      Console.WriteLine($"Please enter your last name");
 *      string LastName = Console.ReadLine();
 *      
 *      Customer c1 = ModelMapper
 * 
 * }
 * else if(userInput == "2")
 * {
 *      
 * 
 * }
 * 
 * }//EndOfusing
 * 2. get the list of products
 * 
 * 
 * 
 * 
 * 3. choose some products
 * 
 * 
 * 
 * 
 * 
 * 4. Complete an order
 * 
 * 
 * 
 * End of Comment Block*/