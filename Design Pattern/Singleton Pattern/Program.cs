using Singleton_Pattern.Models;

class Program
{
    static void Main(string[] args)
    {
        Singleton singleton = Singleton.Instance;
        singleton.SomeMethod();
    }
}