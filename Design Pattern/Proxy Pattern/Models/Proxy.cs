using Proxy_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern.Models
{
    public class Proxy : ISubject
    {
        private RealSubject? _realSubject;

        public void Request()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            Console.WriteLine("Proxy: Performing additional actions before request.");

            _realSubject.Request();

            Console.WriteLine("Proxy: Performing additional actions after request.");
        }
    }
}
