namespace BridgePattern
{
    public abstract class Payment
    {
        public abstract string PaymentType { get; }

        public abstract void Pay(double Total);
    }
}
