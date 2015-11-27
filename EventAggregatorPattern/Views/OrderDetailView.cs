using System;
using EventAggregatorPattern.EventAggregator;
using EventAggregatorPattern.EventAggregator.Events;

namespace EventAggregatorPattern.Views
{
    public class OrderDetailView : ISubscriber<OrderSelected>, ISubscriber<OrderSaved>
    {
        public OrderDetailView(IEventAggregator eventAggregator)
        {
            eventAggregator.Subscribe(this);
        }

        public void OnEvent(OrderSelected e)
        {
            Console.WriteLine("OrderDetailView -> OrderSelected Event -> {0}", e.Order);
        }

        public void OnEvent(OrderSaved e)
        {
            Console.WriteLine("OrderSavedView -> OrderSaved Event -> {0}", e.Order);
        }
    }
}