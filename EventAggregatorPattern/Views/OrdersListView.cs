using System.Collections.Generic;
using System.Linq;
using EventAggregatorPattern.Domain;
using EventAggregatorPattern.EventAggregator;
using EventAggregatorPattern.EventAggregator.Events;

namespace EventAggregatorPattern.Views
{
    public class OrdersListView
    {
        private IList<Order> _orders;

        public IEventAggregator EventAggregator { get; set; }

        public void SelectOrder(int orderNumber)
        {
            Order order = _orders.SingleOrDefault(o => o.OrderNumber == orderNumber);

            if (order != null)
            {
                EventAggregator.Publish(new OrderSelected { Order = order });
            }
        }

        public void SetOrders(IList<Order> orders)
        {
            _orders = orders;
        }
    }
}