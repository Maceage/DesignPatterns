namespace EventAggregatorPattern.Domain
{
    public class Order
    {
        private static int _newID = 1;

        public static int NewID => _newID;

        public Order()
        {
            OrderID = _newID++;
        }

        public int OrderID { get; }
        public int OrderNumber { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"OrderID: {OrderID}, OrderNumber: {OrderNumber}, Description: {Description}";
        }
    }
}