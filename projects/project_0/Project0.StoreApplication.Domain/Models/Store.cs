using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
  public class Store
  {
    public string Name { get; set; }
    public List<Order> Orders { get; set; }

    public Store()
    {
      Name = "GamerX";
      Name = "TechX";
      Name = "MooreX";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
  }


}