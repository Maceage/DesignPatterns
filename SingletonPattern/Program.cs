using System;
using SingletonPattern.Domain;

namespace SingletonPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EagerSingleton eagerSingleton = EagerSingleton.GetInstance();
            Console.WriteLine(eagerSingleton.ToString());

            LazySingleton lazySingleton = LazySingleton.GetInstance();
            Console.WriteLine(lazySingleton.ToString());
        }
    }
}
