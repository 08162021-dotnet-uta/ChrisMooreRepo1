using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// 
  /// </summary>
  public class CustomerRepository : IRepository<Customer>
  {
    private const string _path = @"/home/chris/revature/myRepos/ChrisMooreRepo1/data/customers.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public CustomerRepository()
    {
      if (_fileAdapter.ReadFromFile<Customer>(_path) == null)
      {
        _fileAdapter.WriteToFile<Customer>(_path, new List<Customer>()
        {
          new Customer(){Name = "Jack"},
          new Customer(){Name = "Jeff"}

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
    public bool Insert(List<Customer> entry)
    {
      _fileAdapter.WriteToFile<Customer>(_path, entry);

      return true;
    }

    // Implements Interface - to select the list from the file
    // Reads from the file

    /// <summary>
    /// Selects the list from file through path; Returns that file {customer.xml}
    /// </summary>
    /// <returns></returns>
    public List<Customer> Select()
    {
      return _fileAdapter.ReadFromFile<Customer>(_path);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Customer Update()
    {
      throw new System.NotImplementedException();
    }
  }
}