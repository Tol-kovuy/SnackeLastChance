using System;
using System.Collections.Generic;
using System.Text;

namespace SnackeLastChance
{
    public class GameCore
    {
        public void ToStartGame()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (Snake.Alive)
            {
                Snake.ToMoveSnake();
                FructFactory.ToCreateTheFruict();
                Teacher.ToDrawBrickInTheWall();
                ToReadKey();
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
