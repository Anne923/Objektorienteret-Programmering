namespace Betalingssystem_Nedarvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Payment> payments = new List<Payment>
            {
                new CreditCardPayment { Amount = 250.00m, Currency = "DKK", CardNumber = "1234-5678-9012-3456" },
                new PayPalPayment { Amount = 99.99m, Currency = "USD", Email = "user@example.com" },
                new CreditCardPayment { Amount = 500.00m, Currency = "EUR", CardNumber = "9876-5432-1098-7654" }
            };

            ProcessAllPayments(payments);
        }

        static void ProcessAllPayments(List<Payment> payments)
        {
            foreach (var payment in payments)
            {
                payment.ProcessPayment();
            }
        }
    }
}
