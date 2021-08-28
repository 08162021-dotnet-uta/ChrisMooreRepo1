using System;
using Serilog;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Client.Singletons;
using System.Collections.Generic;

namespace Project0.StoreApplication.Client
{
  public class Program
  {
    // private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;
    private static OrderSingleton _orderSingleton = OrderSingleton.Instance;
    private const string _logFilePath = @"/home/chris/revature/myRepos/ChrisMooreRepo1/data/logs.txt";
    private Product tempProduct;
    private Store tempStore;

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

      var tempStore = _storeSingleton.Stores[Select<Store>(_storeSingleton.Stores)];
      var tempProduct = _productSingleton.Products[Select<Product>(_productSingleton.Products)];
      PrintAllOrder();

      Console.WriteLine("The Selected Store is: " + tempStore);
      Console.WriteLine("The selected product is: " + tempProduct);

      // var customer = _customerSingleton.Customers[Select<Customer>(_customerSingleton.Customers)];
      // var store = _storeSingleton.Stores[Select<Store>(_storeSingleton.Stores)];
      // var product = _productSingleton.Products[Select<Product>(_productSingleton.Products)];
      // var orders = _orderSingleton.Orders[Select<Order>(_orderSingleton.Orders)];

      // Console.WriteLine(customer);
      // Console.WriteLine(store);
      // Console.WriteLine(product);
      if(ConfirmPurchase())
      {
        _orderSingleton.AddToOrderRepository(tempStore, tempProduct);
      }
    }





    private static void PrintAllOrder()
    {
      int count = 0;
      foreach(var o in _orderSingleton.getRepo().GetOrders())
      {
        count++;
        Console.WriteLine(count + " - " + o);
      }
    }

    static bool ConfirmPurchase()
    {
      Console.WriteLine("Confirm Purhcase (Y/N): ");
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
      Log.Information($"method: Output of Generic<{typeof(T)}>()");

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
      Log.Information("method: Capture() Generic collection");

      Print<T>(data);
      Console.Write("Choose name: ");

      int selected = int.Parse(Console.ReadLine());

      return selected - 1;
    }
  }
}