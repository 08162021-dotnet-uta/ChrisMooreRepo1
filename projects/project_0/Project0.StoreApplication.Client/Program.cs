using System;
using Serilog;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Client.Singletons;
using System.Collections.Generic;

namespace Project0.StoreApplication.Client
{
  public class Program
  {
    private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
    // private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    // private statuc readonly ProductSingleton _productSingleton = ProductSingleton.Instance;
    private const string _logFilePath = @"/home/chris/revature/myRepos/ChrisMooreRepo1/data/logs.txt";

    /// <summary>
    /// Defines the Main Method
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.File(_logFilePath).CreateLogger();

      Run();
    }

    /// <summary>
    /// 
    /// </summary>
    private static void Run()
    {
      Log.Information("method: Run()");

      // if (_customerSingleton.Customers.Count == 0)
      // {
      //   _customerSingleton.Add(new Customer());
      // }

      var customer = _customerSingleton.Customers[Capture<Customer>(_customerSingleton.Customers)];
      // var store = _storeSingleton.Stores[Capture<Store>(_storeSingleton.Stores)];
      // var store = _productSingleton.Product[Capture<Product>(_productSingleton.Product)];


      Console.WriteLine(customer);
    }

    /// <summary>
    /// 
    /// </summary>
    private static void Output<T>(List<T> data) where T : class
    {
      Log.Information($"method: Output<{typeof(T)}>()");

      var index = 0;

      foreach (var item in data)
      {
        Console.WriteLine($"[{++index}] - {item}");
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static int Capture<T>(List<T> data) where T : class
    {
      Log.Information("method: Capture()");

      Output<T>(data);
      Console.Write("make selection: ");

      int selected = int.Parse(Console.ReadLine());

      return selected - 1;
    }
  }


  /// <summary>
  /// Defines the Program class
  /// </summary>
  // class Program
  // {
  //   static void Main(string[] args)
  //   {
  //     // Review logger and Serialization
  //     Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();



  //     PrintStoreLocations();
  //     Console.WriteLine(SelectAStore());


  //   }
  //   static void PrintStoreLocations()
  //   {
  //     Log.Information("This is for store output");

  //     var storeRepository = new StoreRepository();
  //     int i = 1;

  //     foreach (var store in storeRepository.Stores)
  //     {
  //       Console.WriteLine(i + " - " + store);
  //       i += 1;
  //     }
  //   }

  //   static Store SelectAStore()
  //   {
  //     Log.Information("Grabbing a store");

  //     var sr = new StoreRepository().Stores;

  //     Console.WriteLine("Select a Store: ");
  //     var option = int.Parse(Console.ReadLine());
  //     var store = sr[option - 1];

  //     return store;


  //   }
  // }
}
