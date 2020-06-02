using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObServer
{
    public class UserObserver : IObserver
    {
        Users users;
        List<string> user = new List<string>();
        public UserObserver()
        {
            users = new Users();
        }
        public void notify(string message,Func<object,int>list1, Func<object, int> list2, Func<object, int> list3)
        {
            user = users.KullanicilariCek();
            foreach (var item in user)
            {
                if (item == "Kullanıcı-1")
                    list1(message);
                if (item == "Kullanıcı-2")
                    list2(message);
                if (item == "Kullanıcı-3")
                    list3(message);

            }
        }
        
    }
}
