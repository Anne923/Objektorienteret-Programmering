namespace Betalingssystem_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPayment> payments = new List<IPayment>
            {
                new CreditCardPayment(),
                new PayPalPayment(),
                new CreditCardPayment(),
                new PayPalPayment()
            };

            decimal[] amounts = { 250.00m, 99.99m, 500.00m, 149.50m };

            for (int i = 0; i < payments.Count; i++)
            {
                payments[i].ProcessPayment(amounts[i]);
            }
        }
    }
}
