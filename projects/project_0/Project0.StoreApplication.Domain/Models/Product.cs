using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
   public class Product
  {
    public string Name { get; set; }
    public List<Order> Orders { get; set; }

    public Product()
    {
      Name = "";
      Name = "";
      Name = "";
    }

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