namespace SingletonPattern.Domain
{
    public class LazySingleton
    {
        private static readonly object _lockObject = new object();

        private static LazySingleton _instance;

        private LazySingleton()
        {
        }

        public static LazySingleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new LazySingleton();
                    }
                }
            }

            return _instance;
        }

        public override string ToString()
        {
            return "Lazy Singleton Instance";
        }
    }
}