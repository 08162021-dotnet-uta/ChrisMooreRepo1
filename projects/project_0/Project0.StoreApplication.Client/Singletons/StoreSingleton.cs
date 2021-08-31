
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{
/// <summary>
  /// 
  /// </summary>
  public class StoreSingleton
  {
    // Instance of store singleton
    private static StoreSingleton _storeSingleton;
    // Creation of store repoistory
    private static StoreRepository _storeRepository = new StoreRepository();

    // List of stores used by _storesingleton
    public List<Store> Stores { get;}
    public static StoreSingleton Instance
    {
      get
      {
        if (_storeSingleton == null)
        {
          _storeSingleton = new StoreSingleton();
        }

        return _storeSingleton;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    private StoreSingleton()
    {
      Stores = _storeRepository.Select();
    }
  }
}