using System.Collections.Generic;
// using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{    public class StoreRepository : IRepository<Store>
  {
    private const string _path = @"/home/chris/revature/ChrisMooreRepo1/data/stores.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public StoreRepository()
    {
       if (_fileAdapter.ReadFromFile<Store>(_path) == null)
      {
        _fileAdapter.WriteToFile<Store>(_path, new List<Store>(){

          new Store(),
          new Store(),
          new Store()

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
  
    
    // public List<Store> Stores { get; }

    // public StoreRepository()
    // {
    //   // var fileAdapter = new FileAdapter();

    //   // if(fileAdapter.ReadFromFile() == null)
    //   // {
    //   //   fileAdapter.WriteToFile(new List<Store>();
    //   // }

    //   Stores = new List<Store>()
    //   {
    //     new GamerStore(),
    //     new MooreStore(),
    //     new TechStore()
    //   };
  }
  
}