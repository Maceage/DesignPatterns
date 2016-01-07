using LazyLoadPattern.ValueHolder.Framework.Interfaces;

namespace LazyLoadPattern.ValueHolder.Framework
{
	public class ValueHolder<T>
	{
		private readonly IValueLoader<T> _loader;
		private T _value;

		public ValueHolder(IValueLoader<T> loader)
		{
			_loader = loader;
		}

		public T Value
		{
			get
			{
				if (_value == null)
				{
					_value = _loader.Load();
				}

				return _value;
			}
		}
	}
}