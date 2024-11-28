namespace Singleton_Pattern.Models
{
    public class Singleton
    {
        private static Singleton? _instance;
        private static readonly object _lock = new object();

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }

        // 예시 메서드
        public void SomeMethod()
        {
            Console.WriteLine("싱글톤 메서드 호출");
        }
    }
}