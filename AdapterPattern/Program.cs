using System;
using AdapterPattern.Domain;
using AdapterPattern.Domain.Adapters;
using AdapterPattern.Domain.Plugs;

namespace AdapterPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Creating Australian Plug socket...");
			AustralianPlugSocket australianPlugSocket = new AustralianPlugSocket();

			Console.WriteLine("Plugging American power plug into Australian plug socket...");
			AmericanPowerPlug americanPowerPlug = new AmericanPowerPlug();
			AmericanPowerPlugAdapter americanPowerPlugAdapter = new	AmericanPowerPlugAdapter(americanPowerPlug);
			australianPlugSocket.PlugIn(americanPowerPlugAdapter);

			Console.WriteLine("Plugging UK power plug into Australian plug socket...");
			UkPowerPlug ukPowerPlug = new UkPowerPlug();
			UkPowerPlugAdapter ukPowerPlugAdapter = new UkPowerPlugAdapter(ukPowerPlug);
			australianPlugSocket.PlugIn(ukPowerPlugAdapter);

			Console.ReadLine();
		}
	}
}