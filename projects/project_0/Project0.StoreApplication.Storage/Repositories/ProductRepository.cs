using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// 
  /// </summary>
  public class ProductRepository : IRepository<Product>
  {
    private const string _path = @"/home/chris/revature/myRepos/ChrisMooreRepo1/data/products.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();
/// <summary>
/// 
/// </summary>
    public ProductRepository()
    {
      if (_fileAdapter.ReadFromFile<Product>(_path) == null)
      {
        _fileAdapter.WriteToFile<Product>(_path, new List<Product>()
        {
          new Product(){Name = "Computer", Price = 479.00, Quantity = 10},
          new Product(){Name = "Game", Price = 60.00, Quantity = 30}

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

    // The insert function 
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool Insert(List<Product> entry)
    {
      _fileAdapter.WriteToFile<Product>(_path, entry);

      return true;
    }

    // Implements Interface - to select the list from the file
    // Reads from the file

    /// <summary>
    /// Selects the list from file through path; Returns that file {customer.xml}
    /// </summary>
    /// <returns></returns>
    public List<Product> Select()
    {
      return _fileAdapter.ReadFromFile<Product>(_path);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Product Update()
    {
      throw new System.NotImplementedException();
    }
  }
}