using EventAggregatorPattern.Domain;

namespace EventAggregatorPattern.EventAggregator.Events
{
    public class OrderSaved
    {
        public Order Order { get; set; }
    }
}