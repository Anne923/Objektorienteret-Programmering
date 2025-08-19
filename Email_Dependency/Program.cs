using Microsoft.Extensions.DependencyInjection;

namespace Email_Dependency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddTransient<IEmailSender, SmtpEmailSender>();
            services.AddTransient<ILogger, ConsoleLogger>();
            services.AddTransient<NotificationService>();

            var provider = services.BuildServiceProvider();

            var notificationService = provider.GetRequiredService<NotificationService>();
            notificationService.SendWelcomeEmail("anne@example.com");
        }
    }
}
