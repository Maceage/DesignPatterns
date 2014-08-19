using System;

namespace FlyweightPattern.Domain
{
    public class Order
    {
        private readonly int _tableNumber;

        private readonly CoffeeFlavour _flavour;

        public Order(int tableNumber, CoffeeFlavour flavour)
        {
            _tableNumber = tableNumber;
            _flavour = flavour;
        }

        public void Serve()
        {
            Console.WriteLine("Serving {0} to table {1}", _flavour, _tableNumber);
        }
    }
}