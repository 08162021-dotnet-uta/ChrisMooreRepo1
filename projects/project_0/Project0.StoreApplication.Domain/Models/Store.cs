using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
  public class Store
  {
    public byte StoreID {get; set;}
    public string Name { get; set; }
    public List<Order> Orders { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return Name;
    }
  }
}