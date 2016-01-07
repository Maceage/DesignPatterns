using System;
using System.Collections.Generic;
using LazyLoadPattern.ValueHolder.Framework.Interfaces;

namespace LazyLoadPattern.ValueHolder.Domain
{
    public class OrderItemLoader : IValueLoader<List<OrderItem>>
    {
        public OrderItemLoader(int orderId)
        {
            OrderId = orderId;
        }

		public int OrderId { get; private set; }

		public List<OrderItem> Load()
        {
            Console.WriteLine("Fetching OrderItems from Database");
            return new List<OrderItem>();
        }
    }
}