namespace ThreadSafe.Domain
{
    public class Singleton
    {
        private Singleton() { }

        private static readonly object _lock = new object();

        private static Singleton _instance;

        public string Value { get; private set; }

        public static Singleton GetIntance(string value)
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                        _instance.Value = value;
                    }
                }
            }

            return _instance;
        }
    }
}