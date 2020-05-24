using ProxyPattern.Abstract;

namespace ProxyPattern.Concrete
{
    public class RealMessage : IMessage
    {
        public string getList()
        {
            return "Merhaba Ben İsmet...\nMerhaba Ben Ceyda...\nMerhaba Ben Furkan...\nMerhaba Ben Gülşah";
        }
    }
}
