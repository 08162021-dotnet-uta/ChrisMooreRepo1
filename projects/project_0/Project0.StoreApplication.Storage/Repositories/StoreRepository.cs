using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{ 
  /// <summary>
  /// Store Repository holds the store.xml path, Store Repository constructor with locations, and insert method for list of stores
  /// </summary>   
  public class StoreRepository : IRepository<Store>
  {
    private const string _path = @"/home/chris/revature/myRepos/ChrisMooreRepo1/data/stores.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    /// <summary>
    /// Store Repository constructor 
    /// </summary>
    public StoreRepository()
    {
      // If statement: If there isn't a stores.xml file --> create new file, write list of stores, give stores avalue
       if (_fileAdapter.ReadFromFile<Store>(_path) == null)
      {
        _fileAdapter.WriteToFile<Store>(_path, new List<Store>()
        {
          new Store(){Location = "Phelan"},
          new Store(){Location = "Barstow"},
          new Store(){Location = "Victorville"}
        });
      }
    }
    

    /// <summary>
    /// Delete is not used at this time
    /// </summary>
    /// <returns></returns>
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    /// <summary>
    /// Insert is not used at this time
    /// </summary>
    /// <returns></returns>
    public bool Insert(List<Store> entry)
    {
      _fileAdapter.WriteToFile<Store>(_path, entry );

      return true;
    }

    /// <summary>
    /// Selects the stores from file; Returns the stores.
    /// </summary>
    /// <returns></returns>
    public List<Store> Select()
    {
      return _fileAdapter.ReadFromFile<Store>(_path);
    }

    /// <summary>
    /// Update is not used at this time
    /// </summary>
    /// <returns></returns>
    public Store Update()
    {
      throw new System.NotImplementedException();
    }

  }
  
}