using System;
using CompositeDesignPattern.Domain;

namespace CompositeDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int goldForKill = 120000;

            Console.WriteLine("The monster has been slain! You earned {0} gold!", goldForKill);

            var virion = new Person { Name = "Virion Scourgeglare" };
            var zehaden = new Person { Name = "Zehaden Leafreaver" };

            var bommink = new Person { Name = "Bommink Spannergear" };
            var miloraen = new Person { Name = "Miloraen Greenwater" };
            var dong = new Person { Name = "Dong Thunderflower" };
            var bramren = new Person { Name = "Bramren Frostmane" };

            var towne = new Person { Name = "Towne Thackeray" };
            var stanmore = new Person { Name = "Stanmore Brent" };

            var humans = new Group { Members = { towne, stanmore } };

            var alliance = new Group { Name = "Alliance", Members = { bommink, miloraen, dong, bramren, humans } };

            var raidGroup = new Group { Members = { alliance, virion, zehaden } };

            raidGroup.Gold += goldForKill;
            raidGroup.Stats();

            Console.ReadKey();
        }
    }
}
