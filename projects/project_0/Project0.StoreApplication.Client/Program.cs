using System;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Storage;
using Serilog;

namespace Project0.StoreApplication.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();



      PrintStoreLocations();
      Console.WriteLine(SelectAStore());


    }
    static void PrintStoreLocations()
    {
      Log.Information("This is for store output");

      var storeRepository = new StoreRepository();
      int i = 1;

      foreach (var store in storeRepository.Stores)
      {
        Console.WriteLine(i + " - " + store);
        i += 1;
      }
    }

    static Store SelectAStore()
    {
      Log.Information("Grabbing a store");

      var sr = new StoreRepository().Stores;

      Console.WriteLine("Select a Store: ");
      var option = int.Parse(Console.ReadLine());
      var store = sr[option - 1];

      return store;


    }
  }
}
