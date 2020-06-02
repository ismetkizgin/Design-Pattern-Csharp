using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObServer
{
    public interface IObSerVable
    {
        void addObserver(string kullanici);
        void removeObserver(string kullanici);
        void notifyObserver(string kullanici,string islem);
    }
}
