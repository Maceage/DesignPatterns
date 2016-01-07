using System;
using System.Collections.Generic;

namespace LazyLoadPattern.Ghosts.Domain
{
    public class OrderItemRepository
    {
        public IEnumerable<OrderItem> ListForOrder(int orderId)
        {
            Console.WriteLine("Fetching order items from database");

            var items = new List<OrderItem>
			{
                new OrderItem(),
                new OrderItem(),
                new OrderItem()
            };

            return items;
        }
    }
}