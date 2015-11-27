using EventAggregatorPattern.Domain;

namespace EventAggregatorPattern.EventAggregator.Events
{
    public class OrderCreated
    {
        public Order Order { get; set; }
    }
}