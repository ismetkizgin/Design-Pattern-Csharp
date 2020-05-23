using BridgePattern.Abstract;

namespace BridgePattern.Concrete
{
    public class OrderPaymentManager : PaymentManager
    {
        public override string PaymentType
        {
            get
            {
                return _payment.PaymentType;
            }
        }

        public override void Pay(double Total)
        {
            _payment.Pay(Total);
        }
    }
}
