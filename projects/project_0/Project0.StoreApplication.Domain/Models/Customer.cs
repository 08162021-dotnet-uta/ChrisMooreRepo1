using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
  public class Customer
  {
    public byte CustomerId { get; set; }
    public string Name { get; set; }
    public List<Order> Orders { get; set; }

    public Customer()
    {
      Name = "It Wednesday";

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return Name;
      // return $"{Name} with {Orders.Count}";
    }
  }
}