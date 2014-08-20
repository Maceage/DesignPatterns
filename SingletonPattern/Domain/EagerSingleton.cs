namespace SingletonPattern.Domain
{
    public class EagerSingleton
    {
        private static readonly EagerSingleton _instance = new EagerSingleton();

        private EagerSingleton()
        {
        }

        public static EagerSingleton GetInstance()
        {
            return _instance;
        }

        public override string ToString()
        {
            return "Eager Singleton Instance";
        }
    }
}