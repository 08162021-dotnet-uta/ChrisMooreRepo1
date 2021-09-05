using Project0.StoreApplication.Domain.Models;
using System.Collections.Generic;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class ProductSingleton
  {
    //
    private static ProductSingleton _productSingleton;

    //
    private static readonly ProductRepository _productRepository = new ProductRepository();

    // 
    public List<Product> Products { get;}

    // Makes sure there is only a single instance
    public static ProductSingleton Instance
    {
      get
      {
        if (_productSingleton == null)
        {
          _productSingleton = new ProductSingleton();
        }

        return _productSingleton;
      }
    }//EoPS check

    /// <summary>
    /// Uses a private contructor to instantiate the product repository to call the read for the product path
    /// </summary>
    private ProductSingleton()
    {
      Products = _productRepository.Select();
    }

  }//EoC
}//EoN