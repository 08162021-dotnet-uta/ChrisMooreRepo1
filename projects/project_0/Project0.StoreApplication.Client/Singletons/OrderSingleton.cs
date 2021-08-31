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
    //
    private static OrderSingleton _orderSingleton;

    //
    private static readonly OrderRepository _orderRepository = new OrderRepository();

    // 
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
    }

    /// <summary>
    /// Private order singleton constructor, 
    /// </summary>
    private OrderSingleton()
    {
      // Uses a private contructor to instantiate the order repo to call the read for the order path
      _orderRepository.Select();
    }

    public void AddToOrderRepository(Store s, Product p)
    {
      _orderRepository.AddOrder(s, p);
    }


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public OrderRepository getRepo()
    {
      return _orderRepository;
    }
  }
}