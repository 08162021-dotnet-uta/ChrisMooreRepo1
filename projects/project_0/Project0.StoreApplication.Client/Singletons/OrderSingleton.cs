using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// OrderSingleton class 
  /// </summary>
  public class OrderSingleton
  {
    // Creates the order singleton instance;
    private static OrderSingleton _orderSingleton;

    // Instantiates the order repository for the order singleton class
    private static readonly OrderRepository _orderRepository = new OrderRepository();

    // gets the order list for the order singleton class
    public List<Order> Orders { get; set;}

    // Makes sure there is only a single instance
    public static OrderSingleton Instance
    {
      get
      {
        if (_orderSingleton == null)
        {
          _orderSingleton = new OrderSingleton();
        }

        return _orderSingleton;
      }
    }//EoOS check

    /// <summary>
    /// private singleton constructor, that is uses te select method to read the order.xml file
    /// </summary>
    private OrderSingleton()
    {
      // Uses a private contructor to instantiate the order repo to call the read for the order path
      _orderRepository.Select();
    }

    /// <summary>
    /// Creates a method that takes two parameters 
    /// </summary>
    /// <param name="s"></param>
    /// <param name="p"></param>
    public void AddToOrderRepository(Store s, Product p)
    {
      _orderRepository.AddOrder(s, p);
    }


    /// <summary>
    /// Uses a private contructor to instantiate the order repository to call the read for the order path
    /// </summary>
    /// <returns></returns>
    public OrderRepository getRepo()
    {
      return _orderRepository;
    }
  }//EoC
}//EoN