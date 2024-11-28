using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Models
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Specific request from Adaptee.");
        }
    }
}
