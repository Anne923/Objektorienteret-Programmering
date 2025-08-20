using Microsoft.Extensions.DependencyInjection;

namespace Logger_Dependency
{
    internal class Program
    {
        static void Main()
        {
            var services = new ServiceCollection();

            
            services.AddTransient<ILogger, ConsoleLogger>();
            services.AddTransient<UserService>();

            var provider = services.BuildServiceProvider();

            var userService = provider.GetRequiredService<UserService>();
            userService.CreateUser("Clara");
        }
    }
}
