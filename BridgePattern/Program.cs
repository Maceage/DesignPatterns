using System;
using System.Collections.Generic;
using BridgePattern.Domain;
using BridgePattern.Formatters;

namespace BridgePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintWithStandardFormatter();
            PrintWithBackwardsFormatter();
            PrintWithFancyFormatter();

            Console.ReadKey();
        }

        private static void PrintWithStandardFormatter()
        {
            Console.WriteLine("-> Start Standard Formatter <-");

            Print(new StandardFormatter());

            Console.WriteLine("-> End Standard Formatter <-");
            Console.WriteLine();
        }

        private static void PrintWithBackwardsFormatter()
        {
            Console.WriteLine("-> Start Backwards Formatter <-");

            Print(new BackwardsFormatter());

            Console.WriteLine("-> End Backwards Formatter <-");
            Console.WriteLine();
        }

        private static void PrintWithFancyFormatter()
        {
            Console.WriteLine("-> Start Fancy Formatter <-");

            Print(new FancyFormatter());

            Console.WriteLine("-> End Fancy Formatter <-");
            Console.WriteLine();
        }

        private static void Print(IFormatter formatter)
        {
            List<Publication> documents = new List<Publication>();

            var newspaper = new Newspaper(formatter);
            newspaper.Title = "The Publicist";
            newspaper.Articles.Add("Sugar linked to bad eyesight", "Rod Sugar");
            newspaper.Articles.Add("Sweden bans chocolate", "Willy Wonka");
            newspaper.Articles.Add("Opera house to be painted orange", "Orange Arup");
            documents.Add(newspaper);

            var book = new Book(formatter)
            {
                Title = "Price of Silence",
                Author = "Jay and Silent Bob",
                Text = "Blah-de-blah-de-blah..."
            };

            documents.Add(book);

            var magazine = new Magazine(formatter)
            {
                Name = "MixMag",
                PrintDate = "30/08/1993",
                CoverHeadline = "Downloads outstrip CD sales"
            };

            documents.Add(magazine);

            foreach (var doc in documents)
            {
                doc.Print();
            }
        }
    }
}
