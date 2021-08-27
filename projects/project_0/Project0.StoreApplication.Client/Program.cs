using System;
using Serilog;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Client.Singletons;
using System.Collections.Generic;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client
{
  public class Program
  {
    private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;
    private const string _logFilePath = @"/home/chris/revature/myRepos/ChrisMooreRepo1/data/logs.txt";

    /// <summary>
    /// Enters the Program
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

      var customer = _customerSingleton.Customers[Select<Customer>(_customerSingleton.Customers)];
      var store = _storeSingleton.Stores[Select<Store>(_storeSingleton.Stores)];
      var product = _productSingleton.Products[Select<Product>(_productSingleton.Products)];


      Console.WriteLine(customer);
      Console.WriteLine(store);
      Console.WriteLine(product);
    }

    /// <summary>
    /// 
    /// </summary>
    private static void Print<T>(List<T> data) where T : class
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
    private static int Select<T>(List<T> data) where T : class
    {
      Log.Information("method: Capture()");

      Print<T>(data);
      Console.Write("Choose name: ");

      int selected = int.Parse(Console.ReadLine());

      return selected - 1;
    }
  }
}