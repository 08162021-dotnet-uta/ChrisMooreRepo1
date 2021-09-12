﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Project1.WebStoreDBContext.Models
{
    public partial class Order
    {
        public Order()
        {
            ItemizedOrders = new HashSet<ItemizedOrder>();
        }

        public Guid OrderId { get; set; }
        public int StoreId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<ItemizedOrder> ItemizedOrders { get; set; }
    }
}
