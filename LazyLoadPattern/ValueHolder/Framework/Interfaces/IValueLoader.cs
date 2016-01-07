namespace LazyLoadPattern.ValueHolder.Framework.Interfaces
{
    public interface IValueLoader<out T>
    {
        T Load();
    }
}