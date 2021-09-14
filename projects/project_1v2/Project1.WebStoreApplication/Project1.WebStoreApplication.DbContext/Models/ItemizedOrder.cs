using System;
using System.Collections.Generic;

#nullable disable

namespace Project1.WebStoreApplication.DbContext.Models
{
    public partial class ItemizedOrder
    {
        public Guid ItemizedId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
