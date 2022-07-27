using System;

namespace SnackeLastChance
{
    class Program
    {
        static void Main()
        {
            IGameCore snake = new GameCore();
            snake.ToStartGame();
        }
    }
}
