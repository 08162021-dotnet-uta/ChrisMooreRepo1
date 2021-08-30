using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
  public class Customer
  {
    public byte CustomerId { get; set; }
    public string CustomerName { get; set; }
    public List<Order> Orders { get; set; }

    // public Customer()
    // {

    // }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return CustomerName;
      // return $"{Name} with {Orders.Count}";
    }
  }
}