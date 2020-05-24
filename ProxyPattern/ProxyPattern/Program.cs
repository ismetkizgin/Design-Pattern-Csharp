using ProxyPattern.Abstract;
using ProxyPattern.Concrete;
using ProxyPattern.Modal;
using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessage message;

            User user = new User();
            user.UserFirstName = "Abdullah";
            user.UserLastName = "Kizgin";
            user.UserType = "Admin";

            message = new ProxyMessage(user);
            Console.WriteLine("********** User Admin **********\n");
            Console.WriteLine(message.getList());

            //User Change
            user.UserFirstName = "İsmet";
            user.UserLastName = "Kizgin";
            user.UserType = "Normal";

            message = new ProxyMessage(user);
            Console.WriteLine("\n\n********** User Normal **********\n");
            Console.WriteLine(message.getList());

            Console.Read();
        }
    }
}
