using System;

namespace BridgePattern.Concrete
{
    public class CartPayment : Payment
    {
        public override string PaymentType
        {
            get
            {
                return "Keredi Kartı ile Ödeme";
            }
        }

        public override void Pay(double Total)
        {
            Console.WriteLine("Kredi kartı ile {0} tutarın da ödemeniz gerçekleşmiştir.", Total);
        }
    }
}
