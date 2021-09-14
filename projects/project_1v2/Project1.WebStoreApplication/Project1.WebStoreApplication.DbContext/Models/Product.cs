using System;
using System.Collections.Generic;

#nullable disable

namespace Project1.WebStoreApplication.DbContext.Models
{
    public partial class Product
    {
        public Product()
        {
            Inventories = new HashSet<Inventory>();
            ItemizedOrders = new HashSet<ItemizedOrder>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<ItemizedOrder> ItemizedOrders { get; set; }
    }
}
