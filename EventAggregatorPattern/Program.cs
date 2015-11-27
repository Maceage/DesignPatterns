using System;
using System.Collections.Generic;
using System.Threading;
using EventAggregatorPattern.Domain;
using EventAggregatorPattern.EventAggregator;
using EventAggregatorPattern.Views;

namespace EventAggregatorPattern
{
    public class Program
    {
        private static IEventAggregator _eventAggregator;

        private static OrdersListView _orderListView;

        //// ReSharper disable NotAccessedField.Local
        private static OrderDetailView _orderDetailView;
        private static OrderHistoryView _orderHistoryView;
        private static OrderView _orderView;
        //// ReSharper restore NotAccessedField.Local

        public static void Main(string[] args)
        {
            _eventAggregator = new SimpleEventAggregator();

            _orderListView = new OrdersListView();

            _orderDetailView = new OrderDetailView(_eventAggregator);
            _orderHistoryView = new OrderHistoryView(_eventAggregator);
            _orderView = new OrderView(_eventAggregator);

            var orders = GenerateOrders();
            _orderListView.EventAggregator = _eventAggregator;
            _orderListView.SetOrders(orders);

            ConsoleKeyInfo consoleKeyInfo;

            do
            {
                Console.Write("Enter an order number: ");
                consoleKeyInfo = Console.ReadKey();
                Console.WriteLine();

                int? number = ParseCharacter(consoleKeyInfo);

                if (number.HasValue)
                {
                    _orderListView.SelectOrder(number.Value);
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }

        private static IList<Order> GenerateOrders()
        {
            IList<Order> orders = new List<Order>();

            orders.Add(new Order { OrderNumber = 1, Description = "An Order" });
            orders.Add(new Order { OrderNumber = 2, Description = "Another Order" });
            orders.Add(new Order { OrderNumber = 3, Description = "Yet Another Order" });

            return orders;
        }

        private static int? ParseCharacter(ConsoleKeyInfo consoleKeyInfo)
        {
            int? number = null;
            int parsedNumber;

            if (int.TryParse(consoleKeyInfo.KeyChar.ToString(), out parsedNumber))
            {
                number = parsedNumber;
            }

            return number;
        }
    }
}
