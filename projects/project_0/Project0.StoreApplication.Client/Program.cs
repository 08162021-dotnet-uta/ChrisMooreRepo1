using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage;

namespace Project0.StoreApplication.Client
{
    class Program
    {
      static void Main(string[] args)
      {
        PrintStoreLocations();
        Console.WriteLine(SelectAStore());

            
      }
      static void PrintStoreLocations()
      {
        var storeRepository = new StoreRepository();
        int i = 1;
       
        foreach(var store in storeRepository.Stores)
        {
          Console.WriteLine(i + " - " + store);
          i+=1;
        }
      }

      static Store SelectAStore()
      {
        var sr = new StoreRepository().Stores;

        Console.WriteLine("Select a Store: ");
        var option = int.Parse(Console.ReadLine());
        var store = sr[option - 1];

        return store;


      }
    }
}
