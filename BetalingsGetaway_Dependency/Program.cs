using Microsoft.Extensions.DependencyInjection;

namespace BetalingsGetaway_Dependency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            
            services.AddTransient<IPaymentProcessor, StripePaymentProcessor>();
            services.AddTransient<CheckoutService>();

            var provider = services.BuildServiceProvider();

            var checkout = provider.GetRequiredService<CheckoutService>();
            checkout.Checkout(299.00m);



            IPaymentProcessor stripe = new StripePaymentProcessor();
            var checkout1 = new CheckoutService(stripe);
            checkout1.Checkout(199.99m);

            IPaymentProcessor paypal = new PayPalPaymentProcessor();
            var checkout2 = new CheckoutService(paypal);
            checkout2.Checkout(49.99m);

            var fake = new FakePaymentProcessor();
            var testCheckout = new CheckoutService(fake);
            testCheckout.Checkout(0.01m);
        }
    }
}
