using EventAggregatorPattern.Domain;

namespace EventAggregatorPattern.EventAggregator.Events
{
    public class OrderSelected
    {
        public Order Order { get; set; }
    }
}