using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Spillogik_Dependency
{
    public class GameRunner
    {
        private readonly IGameEngine _game;

        public GameRunner(IGameEngine game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.Play();
        }
    }
}
