namespace LazyLoadPattern.VirtualProxy.Domain
{
	public class OrderFactory
	{
		public Order CreateFromId(int id)
		{
			return new OrderProxy { Id = id };
		}
	}
}