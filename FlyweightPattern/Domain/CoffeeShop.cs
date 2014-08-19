using System.Collections.Generic;

namespace FlyweightPattern.Domain
{
    public class CoffeeShop
    {
        private readonly List<Order> _orders = new List<Order>();

        private readonly Menu _menu = new Menu();

        public void TakeOrder(string flavourName, int table)
        {
            CoffeeFlavour coffeeFlavour = _menu.Lookup(flavourName);
            Order order = new Order(table, coffeeFlavour);
            _orders.Add(order);
        }

        public void Service()
        {
            foreach (Order order in _orders)
            {
                order.Serve();
            }
        }

        public string Report()
        {
            return string.Format("Total CoffeeFlavour objects made: {0}", _menu.TotalCoffeeFlavoursMade);
        }
    }
}