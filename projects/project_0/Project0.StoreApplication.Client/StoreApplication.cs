using System;
using Serilog;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Client.Singletons;
using System.Collections.Generic;

namespace Project0.StoreApplication.Client
{
  public class StoreApplication
  {
    // private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;
    private static OrderSingleton _orderSingleton = OrderSingleton.Instance;
    //private const string _logFilePath = @"/home/chris/revature/myRepos/ChrisMooreRepo1/data/logs.txt";
    
    public static void StoreRun()
    {
      // Log.Logger = new LoggerConfiguration().WriteTo.File(_logFilePath).CreateLogger();

      // Log.Information("method: Run()");
      
      Console.WriteLine("Welcome Valued Customer!");
      Console.Write("Would you like to see all previous purchases? ");
      if (Confirm())
      {
         PrintAllOrder();
      }
      Console.WriteLine("\nPlease select a local Store: ");
      var Store = _storeSingleton.Stores[Select<Store>(_storeSingleton.Stores)];
      Console.WriteLine("The Selected Store is: {0}", Store);

      Console.WriteLine("\nPlease select a Product: ");
      var Product = _productSingleton.Products[Select<Product>(_productSingleton.Products)];
      Console.WriteLine("The selected product {0} is now in cart", Product);

      // var customer = _customerSingleton.Customers[Select<Customer>(_customerSingleton.Customers)];
      Console.Write("\nWould you like to confirm your purchase? ");
      if(Confirm())
      {
        _orderSingleton.AddToOrderRepository(Store, Product);
      }
    }


  private static void PrintAllOrder()
    {
      int count = 0;
      foreach(var order in _orderSingleton.getRepo().GetOrders())
      {
        Console.WriteLine("{0} - {1}", ++count, order);
      }
    }

    static bool Confirm()
    {
      Console.WriteLine("(Y/N)");
      if (Console.ReadLine() == "Y")
      {
        return true;
      }
      return false;
    }

    /// <summary>
    /// 
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
    /// 
    /// </summary>
    /// <returns></returns>
    private static int Select<T>(List<T> data) where T : class
    {
      Log.Information($"Select Method: Generic<{typeof(T)}>()");

      Print<T>(data);

      int selected = int.Parse(Console.ReadLine());

      return selected - 1;
    }

  }
}