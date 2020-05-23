using BridgePattern.Abstract;
using BridgePattern.Concrete;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentManager payment = new OrderPaymentManager();

            Random random = new Random();
            double total = random.Next(50, 100);

            Console.Write("1. Nakit Ödeme\n2. Kredi Kartı ile Ödeme\n3. Kupon ile Ödeme\n\n{0} Tutarında ki ödemenizi nasıl ödemek isteriniz: ", total);

            while (true)
            {
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        payment._payment = new CashPayment();
                        break;
                    case 2:
                        payment._payment = new CartPayment();
                        break;
                    case 3:
                        payment._payment = new CouponPayment();
                        break;
                }

                if (payment._payment != null)
                    break;

                Console.Write("Lütfen doğru bir ödeme yöntemi seçiniz: ");
            }

            Console.WriteLine("\n\n***********\n");
            payment.Pay(total);

            Console.ReadKey();
        }
    }
}