using System;
using EventAggregatorPattern.EventAggregator;
using EventAggregatorPattern.EventAggregator.Events;

namespace EventAggregatorPattern.Views
{
    public class OrderView : ISubscriber<OrderSelected>, ISubscriber<OrderSaved>
    {
        public OrderView(IEventAggregator eventAggregator)
        {
            eventAggregator.Subscribe(this);
        }

        public void OnEvent(OrderSelected e)
        {
            Console.WriteLine("OrderView -> OrderSelected Event -> {0}", e.Order);
        }

        public void OnEvent(OrderSaved e)
        {
            Console.WriteLine("OrderView -> OrderSaved Event -> {0}", e.Order);
        }
    }
}