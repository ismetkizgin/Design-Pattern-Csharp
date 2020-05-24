using ProxyPattern.Abstract;
using ProxyPattern.Modal;
using System;

namespace ProxyPattern.Concrete
{
    public class ProxyMessage : IMessage
    {
        private User _user;
        private RealMessage realMessage;
        public ProxyMessage(User user)
        {
            _user = user;
        }

        public string getList()
        {
            if (_user.UserType == "Admin")
            {
                realMessage = new RealMessage();
                return realMessage.getList();
            }
            else
                return String.Format("{0} {1} Kullanıcısının Mesajları Görüntülemesine Yetkisi Bulunmamaktadır.", _user.UserFirstName, _user.UserLastName);
        }
    }
}
