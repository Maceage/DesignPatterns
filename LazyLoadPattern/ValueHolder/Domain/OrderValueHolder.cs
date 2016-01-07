using System.Collections.Generic;
using LazyLoadPattern.ValueHolder.Framework;

namespace LazyLoadPattern.ValueHolder.Domain
{
    public class OrderValueHolder
    {
	    private ValueHolder<List<OrderItem>> _items;

	    public OrderValueHolder(int id)
	    {
		    Id = id;
	    }

	    public int Id { get; set; }

	    public List<OrderItem> Items
	    {
		    get { return _items.Value; }
	    }

	    internal void SetItems(ValueHolder<List<OrderItem>> valueHolder)
        {
            _items = valueHolder;
        }
    }
}