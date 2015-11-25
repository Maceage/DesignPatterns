using System;
using FlyweightPattern.Domain;

namespace FlyweightPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CoffeeShop shop = new CoffeeShop();

            shop.TakeOrder("Cappuccino", 2);
            shop.TakeOrder("Frappe", 1);
            shop.TakeOrder("Espresso", 1);
            shop.TakeOrder("Frappe", 897);
            shop.TakeOrder("Cappuccino", 97);
            shop.TakeOrder("Frappe", 3);
            shop.TakeOrder("Espresso", 3);
            shop.TakeOrder("Cappuccino", 3);
            shop.TakeOrder("Espresso", 96);
            shop.TakeOrder("Frappe", 552);
            shop.TakeOrder("Cappuccino", 121);
            shop.TakeOrder("Espresso", 121);

            shop.Service();
            Console.WriteLine(shop.Report());

            Console.ReadLine();
        }
    }
}
