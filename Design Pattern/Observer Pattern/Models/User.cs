using Observer_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Models
{
    public class User : IObserver
    {
        private string _userName;

        public User(string userName, ISubject product)
        {
            _userName = userName;
            // User 인스턴스를 product가 가지고 있는 옵저버 리스트에 등록.
            product.RegisterObserver(this);
        }

        public void ExitObserver(ISubject product)
        {
            product.RemoveObserver(this);
        }

        public void Update(string availability)
        {
            Console.WriteLine($"안녕하세요, {_userName}님! 제품의 가용성이 변경되었습니다: {availability}");
        }
    }
}
