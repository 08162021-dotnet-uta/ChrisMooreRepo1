using Project0.StoreApplication.Domain.Models;
using System.Collections.Generic;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// 
  /// </summary>
  public class CustomerSingleton
  {
    //
    private static CustomerSingleton _customerSingleton;

    //
    private static readonly CustomerRepository _customerRepository = new CustomerRepository();

    // 
    public List<Customer> Customers { get;}

    // Makes sure there is only a single instance
    public static CustomerSingleton Instance
    {
      get
      {
        if (_customerSingleton == null)
        {
          _customerSingleton = new CustomerSingleton();
        }

        return _customerSingleton;
      }
    }

    /// <summary>
    /// Private singleton
    /// </summary>
    private CustomerSingleton()
    {
      // Uses a private contructor to instantiate the customer repo to call the read for the customer path
      Customers = _customerRepository.Select();
    }
  }
}