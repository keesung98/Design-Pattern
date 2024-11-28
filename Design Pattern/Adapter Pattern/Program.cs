using Adapter_Pattern.Interface;
using Adapter_Pattern.Models;

class Program
{
    static void Main(string[] args)
    {
        Adaptee adaptee = new();

        ITarget target = new Adapter(adaptee);
        target.Request();
    }
}
