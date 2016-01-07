namespace LazyLoadPattern.Domain
{
    public class Customer
    {
        public Customer()
        {
            CompanyName = "Company Name";
            Address = "Default Address";
        }

        public string CompanyName { get; set; }
        public string Address { get; set; }
    }
}