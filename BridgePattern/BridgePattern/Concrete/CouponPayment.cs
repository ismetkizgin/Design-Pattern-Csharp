using System;

namespace BridgePattern.Concrete
{
    public class CouponPayment : Payment
    {
        public override string PaymentType
        {
            get
            {
                return "Kupon ile Ödeme";
            }
        }

        public override void Pay(double Total)
        {
            Console.WriteLine("Kupon ile {0} tutarın da ödemeniz gerçekleşmiştir.", Total);
        }
    }
}
