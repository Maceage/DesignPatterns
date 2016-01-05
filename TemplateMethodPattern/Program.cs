using System;
using System.Text;
using TemplateMethodPattern.Domain;

namespace TemplateMethodPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			SendAusPostShipment();
			SendDhlShipment();
			SendPostOfficePostShipment();
			SendTntShipment();

			Console.ReadLine();
		}

		private static void SendAusPostShipment()
		{
			StringBuilder stringBuilder = new StringBuilder();

			Console.WriteLine("Sending order to AusPost");

			AusPostShipment ausPostShipment = new AusPostShipment { ShippingAddress = "1 Australia Road, Australia" };

			ausPostShipment.Ship(stringBuilder);
			Console.WriteLine(stringBuilder.ToString());
		}

		private static void SendDhlShipment()
		{
			StringBuilder stringBuilder = new StringBuilder();

			Console.WriteLine("Sending order to DHL");

			DhlShipment dhlShipment = new DhlShipment { ShippingAddress = "1 Dunno How Laneway, Germany" };

			dhlShipment.Ship(stringBuilder);
			Console.WriteLine(stringBuilder.ToString());
		}

		private static void SendPostOfficePostShipment()
		{
			StringBuilder stringBuilder = new StringBuilder();

			Console.WriteLine("Sending order to Post Office");

			PostOfficeShipment postOfficeShipment = new PostOfficeShipment { ShippingAddress = "1 Postman Pat Close, United Kingdom" };

			postOfficeShipment.Ship(stringBuilder);
			Console.WriteLine(stringBuilder.ToString());
		}

		private static void SendTntShipment()
		{
			StringBuilder stringBuilder = new StringBuilder();

			Console.WriteLine("Sending order to TNT");

			TntShipment tntShipment = new TntShipment { ShippingAddress = "C4 Explosive Avenue, United States" };

			tntShipment.Ship(stringBuilder);
			Console.WriteLine(stringBuilder.ToString());
		}
	}
}
