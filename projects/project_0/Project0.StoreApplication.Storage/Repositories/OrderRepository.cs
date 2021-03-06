using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// 
  /// </summary>
  public class OrderRepository : IRepository<Order>
  {
    private const string _path = @"/home/chris/revature/myRepos/ChrisMooreRepo1/data/orders.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public static List<Order> Orders = new List<Order>();

    /// <summary>
    /// Checks if the path containing the order list is created, if not creates one, else instantiates order variable with the path 
    /// </summary>
    public OrderRepository()
    {
      if (_fileAdapter.ReadFromFile<Order>(_path) == null)
      {
        _fileAdapter.WriteToFile<Order>(_path, new List<Order>());
      }
      else
      {
        Orders = _fileAdapter.ReadFromFile<Order>(_path);
      }
    }

    /// <summary>
    /// Creates a method with two parameters 
    /// </summary>
    /// <param name="store"></param>
    /// <param name="p"></param>
    public void AddOrder(Store s, Product p)
    {
      Orders.Add(new Order() {Store = s, Product = p});
      _fileAdapter.WriteToFile<Order>(_path, Orders);
      Orders = _fileAdapter.ReadFromFile<Order>(_path);
    }

    /// <summary>
    /// This method returns a list of Orders
    /// </summary>
    /// <returns></returns>
    public List<Order> GetOrders()
    {
      return Orders;
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
    public bool Insert(List<Order> entry)
    {
      _fileAdapter.WriteToFile<Order>(_path, entry);

      return true;
    }

    // Implements Interface - to select the list from the file
    // Reads from the file

    /// <summary>
    /// Selects the list from file through path; Returns that file {order.xml}
    /// </summary>
    /// <returns></returns>
    public List<Order> Select()
    {
      return _fileAdapter.ReadFromFile<Order>(_path);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Order Update()
    {
      throw new System.NotImplementedException();
    }
  }
}