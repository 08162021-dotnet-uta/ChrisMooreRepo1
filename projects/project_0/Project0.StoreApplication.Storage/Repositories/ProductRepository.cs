using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// This class holds the product repository path, product constructor, and inherits the IRepository interface
  /// </summary>
  public class ProductRepository : IRepository<Product>
  {
    private const string _path = @"/home/chris/revature/myRepos/ChrisMooreRepo1/data/products.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();
/// <summary>
/// Checks if the path containing the product list is created, if not creates one by writing products to the path
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
    /// Method not used for Product
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

    /// <summary>
    /// Implements Interface - to select the list from the file.
    /// Selects the list from file through path; Returns that file {product.xml}
    /// </summary>
    /// <returns></returns>
    public List<Product> Select()
    {
      return _fileAdapter.ReadFromFile<Product>(_path);
    }

    /// <summary>
    /// Method not used for product
    /// </summary>
    /// <returns></returns>
    public Product Update()
    {
      throw new System.NotImplementedException();
    }
  }
}