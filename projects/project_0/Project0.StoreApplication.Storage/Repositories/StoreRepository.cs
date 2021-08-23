using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage
{
  public class StoreRepository
  {
    public List<Store> Stores { get; }

    public StoreRepository()
    {
      Stores = new List<Store>()
      {
        new GamerStore(),
        new MooreStore(),
        new TechStore()
      };
    }
  }
}