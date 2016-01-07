using System.Collections.Generic;
using LazyLoadPattern.ValueHolder.Framework;

namespace LazyLoadPattern.ValueHolder.Domain
{
    public class OrderFactory
    {
        public OrderValueHolder CreateFromId(int id)
        {
            var order = new OrderValueHolder(id);
            order.SetItems(new ValueHolder<List<OrderItem>>(new OrderItemLoader(id)));
            return order;
        }
    }
}