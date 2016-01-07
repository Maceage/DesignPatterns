using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LazyLoadPattern.Ghosts.Domain
{
    public class Order : DomainObject
    {
	    private string _shipMethod;
	    private Customer _customer;
	    private Lazy<List<OrderItem>> _items;

	    public Order(int id)
            : base(id)
        {
        }

	    public string ShipMethod
        {
            get
            {
                Load();
                return _shipMethod;
            }

            set
            {
                Load();
                _shipMethod = value;
            }
        }

	    public Customer Customer
        {
            get
            {
                Load();
                return _customer;
            }

            set
            {
                Load();
                _customer = value;
            }
        }

	    public IEnumerable<OrderItem> Items
        {
            get
            {
                Load();
                return _items.Value.AsReadOnly();
            }
        }

        protected override void DoLoadLine(ArrayList dataRow)
        {
            ShipMethod = (string)dataRow[0];
            Customer = new Customer((int)dataRow[1]);
            _items = new Lazy<List<OrderItem>>(() => new OrderItemRepository().ListForOrder(Id).ToList());
        }

        protected override ArrayList GetDataRow()
        {
            var row = new ArrayList();

            row.Add("FEDEX");
            row.Add(123);

            return row;
        }
    }
}