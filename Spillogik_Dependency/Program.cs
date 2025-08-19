using Microsoft.Extensions.DependencyInjection;

namespace Spillogik_Dependency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();


            var random = new Random();
            GameType selectedGame = (GameType)random.Next(0, Enum.GetNames(typeof(GameType)).Length);


            switch (selectedGame)
            {
                case GameType.GuessNumber:
                    services.AddTransient<IGameEngine, GuessNumberGame>();
                    break;
                case GameType.RockPaperScissors:
                    services.AddTransient<IGameEngine, RockPaperScissorsGame>();
                    break;
            }

            services.AddTransient<GameRunner>();

            var provider = services.BuildServiceProvider();
            var runner = provider.GetRequiredService<GameRunner>();
            runner.Run();
        }
    }
}
