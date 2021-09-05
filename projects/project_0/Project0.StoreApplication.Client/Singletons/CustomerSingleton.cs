using Project0.StoreApplication.Domain.Models;
using System.Collections.Generic;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// This singleton is used to access customer repository 
  /// </summary>
  public class CustomerSingleton
  {
    // Creates the customer singleton instance.
    private static CustomerSingleton _customerSingleton;

    /// <summary>
    /// Instantiates the customer repository in customer singleton class
    /// </summary>
    /// <returns></returns>
    private static readonly CustomerRepository _customerRepository = new CustomerRepository();

    // In this singleton class scope it gets the customer list for the singleton.
    public List<Customer> Customers { get;}

    /// <summary>
    /// This test to make sure there is only one instance of Customer Singleton
    /// </summary>
    /// <value></value>
    public static CustomerSingleton Instance
    {
      // Uses get to check/create or return the customer singleton
      get
      {
        if (_customerSingleton == null)
        {
          _customerSingleton = new CustomerSingleton();
        }
        return _customerSingleton;
      }
    }//EoCS check

    /// <summary>
    /// private singleton constructor, that is uses te select method to read the customer.xml file
    /// </summary>
    private CustomerSingleton()
    {
      // Instantiates the customer list selected as Customers
      Customers = _customerRepository.Select();
    }
  }//EoC
}//EoN