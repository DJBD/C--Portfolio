namespace QuestionFive
{
    public class Singleton
    {
        public string Value { get; set; }
        private Singleton()
        {
        }

        private static Singleton _instance;
        
        private static readonly object _lock = new object();

        public static Singleton GetInstance(string value)
        {
            if (_instance == null)
            {
                lock(_lock) // the lock here is useful when it comes to threads. The first thread that reaches here will lock it so that it won't change. The other threads will have to wait.
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