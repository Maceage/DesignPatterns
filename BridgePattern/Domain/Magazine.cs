using System;
using BridgePattern.Formatters;

namespace BridgePattern.Domain
{
    public class Magazine : Publication
    {
        public Magazine(IFormatter formatter) 
            : base(formatter)
        {
        }

        public string Name { get; set; }
        public string PrintDate { get; set; }
        public string CoverHeadline { get; set; }

        public override void Print()
        {
            Console.WriteLine(Formatter.Format("Name", Name));
            Console.WriteLine(Formatter.Format("Print Date", PrintDate));
            Console.WriteLine(Formatter.Format("Cover Headline", CoverHeadline));
            Console.WriteLine();
        }
    }
}