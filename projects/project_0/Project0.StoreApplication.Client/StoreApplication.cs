using System;
using Serilog;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Client.Singletons;
using System.Collections.Generic;
using Project0.StoreApplication.Storage.Adapters;
using Project0.StoreApplication.Storage;

namespace Project0.StoreApplication.Client
{
  public class StoreApplication
  {
    // private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;
    private static OrderSingleton _orderSingleton = OrderSingleton.Instance;

    /// <summary>
    /// This path is static so it can be available for the lifetime of the code and instantiated at compile time
    /// </summary>
    private static string genericPath = @"/home/chris/revature/myRepos/ChrisMooreRepo1/data/";

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    /// <summary>
    /// This path is created for logging information 
    /// </summary>
    private const string _logFilePath = @"/home/chris/revature/myRepos/ChrisMooreRepo1/data/logs.txt";
    
    /// <summary>
    /// Creates a constructor with the instructions for the StoreApplication
    /// </summary>
    public StoreApplication()
    {
      //Uses Serilog to instationate a write to file for logging in the application.
      Log.Logger = new LoggerConfiguration().WriteTo.File(_logFilePath).CreateLogger();

      Log.Information("method: StoreAppRun()");
      //Prompt for opening application
      Console.WriteLine("Welcome to the Store Application are most valued Customer!");
      Console.Write("Would you like to preview past purchases before continuing?");
      if (Confirm())
      {
      PrintAllOrder();
      }
      //Prompt for store location
      Console.WriteLine("\nPlease select a Store Location: ");
      var currentStore = _storeSingleton.Stores[Select<Store>(_storeSingleton.Stores)];
      Console.WriteLine("The Selected Store is: {0}", currentStore);
      Console.Write("Would you like to see all purchases from {0}?", currentStore);
      if (Confirm())
      {
        Print(GetOrderFromStore(currentStore));
      }

      //Prompts to select a product
      Console.WriteLine("\nPlease select a Product: ");
      var currentProduct = _productSingleton.Products[Select<Product>(_productSingleton.Products)];
      Console.WriteLine("The selected product {0} is now in cart", currentProduct);

      // var customer = _customerSingleton.Customers[Select<Customer>(_customerSingleton.Customers)];
      Console.Write("\nWould you like to confirm your purchase? ");
      if(Confirm())
      {
        Order curOrder = new Order() {Store = currentStore, Product = currentProduct};
        _orderSingleton.AddToOrderRepository(currentStore, currentProduct);
        AddOrderToStore(currentStore, curOrder);
      }
      Console.WriteLine("Thank you for shopping on the Store Application.");
      Console.Write("Have a great day! ");
    }

    //I recieved help on outputting orders to this method so that past purchases can be previewed before shopping
  /// <summary>
  /// For every order called from past orders, print those past orders and increment their count by 1.
  /// </summary>
    private static void PrintAllOrder()
    {
      int count = 0;
      foreach(var order in _orderSingleton.getRepo().GetOrders())
      {
        Console.WriteLine("{0} - {1}", ++count, order);
      }
    }

    /// <summary>
    /// Uses a confirm message for returning products/orders/stores
    /// </summary>
    /// <returns></returns>
    static bool Confirm()
    {
      //Prompts for a yes or no, denoted by 'Y' and 'N' respectively.
      Console.WriteLine("(Y/N)");
      //If the condition is met return the method or object called.
      if (Console.ReadLine() == "Y")
      {
        return true;
      }
      return false;
    }

    /// <summary>
    /// Uses a print method to pass list data 
    /// </summary>
    private static void Print<T>(List<T> data) where T : class
    {
      Log.Information($"Print Method: Output of Generic<{typeof(T)}>()");

      var index = 0;

      foreach (var item in data)
      {
        Console.WriteLine("[{0}] - {1}", ++index, item);
      }
    }

    /// <summary>
    /// Uses a select method to select a List from print, return user index - 1 
    /// </summary>
    /// <returns></returns>
    private static int Select<T>(List<T> data) where T : class
    {
      Log.Information($"Select Method: Generic<{typeof(T)}>()");

      Print<T>(data);

      int selected = int.Parse(Console.ReadLine());

      return selected - 1;
    }
    /// <summary>
    /// The first parameter is a Store object, The second parameter is an Order Object
    /// </summary>
    /// <param name="s"></param>
    /// <param name="o"></param>
    static void AddOrderToStore(Store s, Order o)
    {
      // Stores the path into a string variable 
      string ThePath = genericPath + s.Location + ".xml";
      // Create the variable from the orders list
      List<Order> tempOrders;

      if (_fileAdapter.ReadFromFile<Order>(ThePath) == null)
      {
        _fileAdapter.WriteToFile<Order>(ThePath, new List<Order>());
      }
      else 
      {
        tempOrders = _fileAdapter.ReadFromFile<Order>(ThePath);
        tempOrders.Add(o);
        _fileAdapter.WriteToFile<Order>(ThePath, tempOrders);
      }
    }
      /// <summary>
      /// Will return a list of orders from the path variable, the parameter given is a Store
      /// </summary>
      /// <param name="s"></param>
      /// <returns></returns>
    static List<Order> GetOrderFromStore(Store s)
      {
        string ThePath = genericPath + s.Location + ".xml";
        return _fileAdapter.ReadFromFile<Order>(ThePath);      
      }
    
    // public static void DBdemo()
    // {
    //   var db = new DBdemo();
    //   db.GetCustomers();
    //   foreach (var item in db.GetCustomers())
    //   {
    //     Console.WriteLine(item);
    //   }
    // }
  }
}