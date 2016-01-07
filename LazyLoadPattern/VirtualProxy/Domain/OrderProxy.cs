using LazyLoadPattern.Domain;

namespace LazyLoadPattern.VirtualProxy.Domain
{
    public class OrderProxy : Order
    {
        public override Customer Customer
        {
            get
            {
	            return base.Customer ?? (base.Customer = new Customer());
            }

	        set
            {
                base.Customer = value;
            }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Order;

	        if (other == null)
	        {
		        return false;
	        }

            return other.Id == Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}