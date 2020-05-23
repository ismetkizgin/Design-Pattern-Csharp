using System;

namespace BridgePattern.Concrete
{
    public class CashPayment : Payment
    {
        public override string PaymentType { 
            get
            {
                return "Nakit Ödeme";
            } 
        }

        public override void Pay(double Total)
        {
            Console.WriteLine("Nakit ödeme ile {0} tutarın da ödemeniz gerçekleşmiştir.", Total);
        }
    }
}
