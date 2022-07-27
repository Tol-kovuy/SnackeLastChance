using Snake;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnackeLastChance
{
    public class GameCore : IGameCore
    {
        public void ToStartGame()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Banner logo = new Banner(new Coordinate(0, 0));
            Console.WriteLine();
            Console.WriteLine("Press any key to play the game...");
            Console.ResetColor();

            while (Snake.Alive)
            {
                ToReadKey();
                Snake.ToMoveSnake();
                FructFactory.ToCreateTheFruict();
                Teacher.ToDrawBrickInTheWall();
            }
        }
        private void ToReadKey()
        {
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (Snake.Right == false)
                    {
                        Snake.Left = true;
                        Snake.Up = Snake.Down = false;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (Snake.Left == false)
                    {
                        Snake.Right = true;
                        Snake.Up = Snake.Down = false;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (Snake.Down == false)
                    {
                        Snake.Up = true;
                        Snake.Left = Snake.Right = false;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Snake.Up == false)
                    {
                        Snake.Down = true;
                        Snake.Left = Snake.Right = false;
                    }
                    break;
            }
        }
    }
}
