using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Domain.Models
{

  /// <summary>
  /// 
  /// </summary>
   public class Order
  {
    public byte OrderID {get; set;}
    public Customer Customer {get; set;}

    public Product Product {get; set;}

    public Store Store {get; set;}


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return "Location: " + Store + ", Product: " + Product;
    }
  }
}