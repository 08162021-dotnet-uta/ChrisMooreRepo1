using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
  public class Product
  {
    public string Name { get; set; }
    public double Price { get; set; }
    public short Quantity { get; set; }

    public override string ToString()
    {
      return Name + ", Price: $" + Price;
    }
  }
}