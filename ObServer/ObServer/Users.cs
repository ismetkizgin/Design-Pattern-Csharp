using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObServer
{
    public class Users : IObSerVable
    {
        public static List<string> users = new List<string>();
        public void addObserver(string kullanici)
        {
            users.Add(kullanici);
            notifyObserver(kullanici, " duyuruya eklendi!");
        }

        public void notifyObserver(string kullanici,string islem)
        {
            XtraMessageBox.Show(kullanici +islem,"Bilgi Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void removeObserver(string kullanici)
        {
            users.Remove(kullanici);
            notifyObserver(kullanici, " duyurudan Silindi!");
        }
        public List<string> KullanicilariCek()
        {
            return users;
        }
    }
}
