public class Singleton
    {
        private Singleton()
        {
        }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
                _instance = new Singleton();
            return _instance;
        }
    }
    public static class SingletonExample
    {
        public static void Test()
        {
            var instance1 = Singleton.GetInstance();
            var instance2 = Singleton.GetInstance();

            if (instance1.Equals(instance2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
        //result:
        //Yes
    }