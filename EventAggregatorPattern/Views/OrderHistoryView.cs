using System;
using EventAggregatorPattern.EventAggregator;
using EventAggregatorPattern.EventAggregator.Events;

namespace EventAggregatorPattern.Views
{
    public class OrderHistoryView : ISubscriber<OrderSelected>, ISubscriber<OrderSaved>
    {
        public OrderHistoryView(IEventAggregator eventAggregator)
        {
            eventAggregator.Subscribe(this);
        }

        public void OnEvent(OrderSelected e)
        {
            Console.WriteLine("OrderHistoryView -> OrderSelected Event -> {0}", e.Order);
        }

        public void OnEvent(OrderSaved e)
        {
            Console.WriteLine("OrderHistoryView -> OrderSaved Event -> {0}", e.Order);
        }
    }
}