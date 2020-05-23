namespace BridgePattern.Abstract
{
    public abstract class PaymentManager
    {
        public Payment _payment;
        public abstract string PaymentType { get; }

        public abstract void Pay(double Total);
    }
}
