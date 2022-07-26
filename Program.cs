using System;

namespace SnackeLastChance
{
    class Program
    {
        FructFactory heart = new FructFactory();

        private static bool up;
        private static bool down;
        private static bool right;
        private static bool left;

        private static bool alive = true;

        public static void ToDrawField()
        {
            Console.Clear();
            Console.CursorVisible = false;

            for (int i = 0; i < GameSettings.BackGroundField.GetLength(0); i++)
            {
                for (int j = 0; j < GameSettings.BackGroundField.GetLength(1); j++)
                {
                    if (GameSettings.BackGroundField[i, j] == 1)
                    {
                        Console.Write("█");
                    }

                    else if (GameSettings.BackGroundField[i, j] >= 2)
                    {
                        Console.Write("■");
                    }
                    else if (GameSettings.BackGroundField[i, j] == -1)
                    {
                        Console.Write("♥");
                    }

                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(GameSettings.Counter);
        }

        

        public static int ToCheckMaxValue()
        {
            int max = 0;

            for (int i = 0; i < GameSettings.BackGroundField.GetLength(0); i++)
            {
                for (int j = 0; j < GameSettings.BackGroundField.GetLength(1); j++)
                {
                    if (GameSettings.BackGroundField[i, j] > max)
                    {
                        max = GameSettings.BackGroundField[i, j];
                    }
                }
            }
            return max;
        }

        public static void ToUpValueBody()
        {
            for (int i = 0; i < GameSettings.BackGroundField.GetLength(0); i++)
            {
                for (int j = 0; j < GameSettings.BackGroundField.GetLength(1); j++)
                {
                    if (GameSettings.BackGroundField[i, j] > 1)
                    {
                        GameSettings.BackGroundField[i, j]++;
                    }
                }
            }
        }
        public static void ToDeleteMaxValue()
        {
            int max = 0;
            int x = 0;
            int y = 0;

            for (int i = 0; i < GameSettings.BackGroundField.GetLength(0); i++)
            {
                for (int j = 0; j < GameSettings.BackGroundField.GetLength(1); j++)
                {
                    if (GameSettings.BackGroundField[i, j] > max)
                    {
                        max = GameSettings.BackGroundField[i, j];
                        x = i;
                        y = j;
                    }
                }
            }

            GameSettings.BackGroundField[x, y] = 0;
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (alive)
            {
                ToMoveSnake();
                FructFactory.ToCreateTheFruict();
                ToDrawField();
                ToReadKey();
            }

        }

        public static void ToReadKey()
        {
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (right == false)
                    {
                        left = true;
                        up = down = false;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (left == false)
                    {
                        right = true;
                        up = down = false;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (down == false)
                    {
                        up = true;
                        left = right = false;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (up == false)
                    {
                        down = true;
                        left = right = false;
                    }
                    break;
            }
        }

        public static void ToMoveSnake()
        {

            int xHead = 0;
            int yHead = 0;

            for (int i = 0; i < GameSettings.BackGroundField.GetLength(0); i++)
            {
                for (int j = 0; j < GameSettings.BackGroundField.GetLength(1); j++)
                {
                    if (GameSettings.BackGroundField[i, j] == 2)
                    {
                        xHead = i;
                        yHead = j;
                    }
                }
            }

            if (up)
            {
                if (GameSettings.BackGroundField[xHead - 1, yHead] > 0) alive = false;
                else
                {
                    if (ToCheckMaxValue() > GameSettings.Counter)
                    {
                        ToDeleteMaxValue();
                    }

                    ToUpValueBody();
                    GameSettings.BackGroundField[xHead - 1, yHead] = 2;
                }

            }

            else if (down)
            {

                if (GameSettings.BackGroundField[xHead + 1, yHead] > 0) alive = false;
                else
                {
                    if (ToCheckMaxValue() > GameSettings.Counter)
                    {
                        ToDeleteMaxValue();
                    }

                    ToUpValueBody();
                    GameSettings.BackGroundField[xHead + 1, yHead] = 2;
                }
            }

            else if (right)
            {
                if (GameSettings.BackGroundField[xHead, yHead + 1] > 0) alive = false;  
                else
                {
                    if (ToCheckMaxValue() > GameSettings.Counter)
                    {
                        ToDeleteMaxValue();
                    }

                    ToUpValueBody();
                    GameSettings.BackGroundField[xHead, yHead + 1] = 2;
                }
            }
            else if (left)
            {
                if (GameSettings.BackGroundField[xHead, yHead - 1] > 0) alive = false;
                else
                {
                    if (ToCheckMaxValue() > GameSettings.Counter)
                    {
                        ToDeleteMaxValue();
                    }

                    ToUpValueBody();
                    GameSettings.BackGroundField[xHead, yHead - 1] = 2;
                }
            }
        }
    }
}
