using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObServer
{
    public interface IObserver
    {
        void notify(string message, Func<object, int> list1, Func<object, int> list2, Func<object, int> list3);
    }
}
