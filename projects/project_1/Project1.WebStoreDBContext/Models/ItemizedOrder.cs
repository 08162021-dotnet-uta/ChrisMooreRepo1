using System;
using System.Collections.Generic;

#nullable disable

namespace Project1.WebStoreDBContext.Models
{
    public partial class ItemizedOrder
    {
        public Guid ItemizedId { get; set; }
        public Guid OrderId { get; set; }
        public int ProductId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
