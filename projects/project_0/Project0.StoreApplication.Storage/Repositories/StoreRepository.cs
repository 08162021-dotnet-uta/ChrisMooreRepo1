using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{    public class StoreRepository : IRepository<Store>
  {
    private const string _path = @"/home/chris/revature/myRepos/ChrisMooreRepo1/data/stores.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    /// <summary>
    /// Store Repository constructor 
    /// </summary>
    public StoreRepository()
    {
       if (_fileAdapter.ReadFromFile<Store>(_path) == null)
      {
        _fileAdapter.WriteToFile<Store>(_path, new List<Store>()
        {

          new Store(){Name = "GamerX"},
          new Store(){Name = "TechX"},
          new Store(){Name = "MooreX"}

        });
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool Insert(List<Store> entry)
    {
      _fileAdapter.WriteToFile<Store>(_path, entry );

      return true;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<Store> Select()
    {
      return _fileAdapter.ReadFromFile<Store>(_path);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Store Update()
    {
      throw new System.NotImplementedException();
    }

  }
  
}