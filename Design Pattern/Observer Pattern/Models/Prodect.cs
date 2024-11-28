using Observer_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Models
{
    public class Product : ISubject
    {
        private readonly List<IObserver> _observers = new();

        private readonly string _productName;
        private string _productAvailability;

        public Product(string productName)
        {
            _productName = productName;
            _productAvailability = "Out of Stock";
        }

        public string ProductAvailability
        {
            get { return _productAvailability; }
            set
            {
                _productAvailability = value;
                // _productAvailability의 내용이 변경될 때 옵저버들에게 변경 사실을 알림.
                NotifyObservers();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_productAvailability);
            }
        }
    }
}
