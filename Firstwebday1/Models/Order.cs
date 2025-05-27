﻿using Firstwebday1.Models;

namespace Firstwebday1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public List<OrderItem> OrderItemList { get; set; }
    }
}