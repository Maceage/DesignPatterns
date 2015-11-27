namespace EventAggregatorPattern.EventAggregator
{
    public interface ISubscriber<T>
    {
        void OnEvent(T e);
    }
}