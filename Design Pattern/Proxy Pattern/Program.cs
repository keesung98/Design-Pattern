using Proxy_Pattern.Interface;
using Proxy_Pattern.Models;

class Program
{
    static void Main(string[] args)
    {
        ISubject subject = new Proxy();
        subject.Request();
    }
}
