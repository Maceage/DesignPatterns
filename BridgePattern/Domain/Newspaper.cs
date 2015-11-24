using System;
using System.Collections.Generic;
using BridgePattern.Formatters;

namespace BridgePattern.Domain
{
    public class Newspaper : Publication
    {
        public Newspaper(IFormatter formatter) 
            : base(formatter)
        {
            Articles = new Dictionary<string, string>();
        }

        public string Title { get; set; }
        public Dictionary<string, string> Articles { get; set; }

        public override void Print()
        {
            Console.WriteLine(Formatter.Format("Title", Title));

            foreach (var article in Articles)
            {
                Console.WriteLine(Formatter.Format("   Heading", article.Key));
                Console.WriteLine(Formatter.Format("   Author", article.Value));
            }

            Console.WriteLine();
        }
    }
}