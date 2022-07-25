using System;

namespace SnackeLastChance
{
    class Program
    {
        private static int[,] backGround =
            {
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
};

        private static int counter = 0;

        private static bool up;
        private static bool down;
        private static bool right;
        private static bool left;

        private static bool alive = true;

        public static void ToDrawField()
        {
            Console.Clear();
            Console.CursorVisible = false;

            for (int i = 0; i < backGround.GetLength(0); i++)
            {
                for (int j = 0; j < backGround.GetLength(1); j++)
                {
                    if (backGround[i, j] == 1)
                    {
                        Console.Write("█");
                    }

                    else if (backGround[i, j] >= 2)
                    {
                        Console.Write("■");
                    }
                    else if (backGround[i, j] == -1)
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
            Console.WriteLine(counter);
        }

        public static void ToCreateTheFruict()
        {
            bool appleFaund = false;

            for (int i = 0; i < backGround.GetLength(0); i++)
            {
                for (int j = 0; j < backGround.GetLength(1); j++)
                {
                    if (backGround[i, j] == -1)
                    {
                        appleFaund = true;
                    }
                }
            }
            if (appleFaund == false)
            {
                Random rand = new Random();
                int x = rand.Next(1, backGround.GetLength(0) - 1);
                int y = rand.Next(1, backGround.GetLength(1) - 1);

                backGround[x, y] = -1;
                counter++;
            }
        }

        public static int ToCheckMaxValue()
        {
            int max = 0;

            for (int i = 0; i < backGround.GetLength(0); i++)
            {
                for (int j = 0; j < backGround.GetLength(1); j++)
                {
                    if (backGround[i, j] > max)
                    {
                        max = backGround[i, j];
                    }
                }
            }
            return max;
        }

        public static void ToUpValueBody()
        {
            for (int i = 0; i < backGround.GetLength(0); i++)
            {
                for (int j = 0; j < backGround.GetLength(1); j++)
                {
                    if (backGround[i, j] > 1)
                    {
                        backGround[i, j]++;
                    }
                }
            }
        }
        public static void ToDeleteMaxValue()
        {
            int max = 0;
            int x = 0;
            int y = 0;

            for (int i = 0; i < backGround.GetLength(0); i++)
            {
                for (int j = 0; j < backGround.GetLength(1); j++)
                {
                    if (backGround[i, j] > max)
                    {
                        max = backGround[i, j];
                        x = i;
                        y = j;
                    }
                }
            }

            backGround[x, y] = 0;
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (alive)
            {
                ToMoveSnake();
                ToCreateTheFruict();
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

            for (int i = 0; i < backGround.GetLength(0); i++)
            {
                for (int j = 0; j < backGround.GetLength(1); j++)
                {
                    if (backGround[i, j] == 2)
                    {
                        xHead = i;
                        yHead = j;
                    }
                }
            }

            if (up)
            {
                if (backGround[xHead - 1, yHead] > 0) alive = false;
                else
                {
                    if(ToCheckMaxValue() > counter)
                    {
                        ToDeleteMaxValue(); 
                    }

                    ToUpValueBody();
                    backGround[xHead - 1, yHead] = 2;
                }
               
            }

            else if (down)
            { 

                if (backGround[xHead + 1, yHead] > 0) alive = false;
                else
                {
                    if (ToCheckMaxValue() > counter)
                    {
                        ToDeleteMaxValue();
                    }

                    ToUpValueBody();
                    backGround[xHead + 1, yHead] = 2;
                }
            }

            else if (right)
            {
                if (backGround[xHead, yHead + 1] > 0) alive = false;
                else
                {
                    if (ToCheckMaxValue() > counter)
                    {
                        ToDeleteMaxValue();
                    }

                    ToUpValueBody();
                    backGround[xHead, yHead + 1] = 2;
                }
            }
            else if (left)
            {
                if (backGround[xHead, yHead - 1] > 0) alive = false;
                else
                {
                    if (ToCheckMaxValue() > counter)
                    {
                        ToDeleteMaxValue();
                    }

                    ToUpValueBody();
                    backGround[xHead, yHead - 1] = 2;
                }
            }
        }
    }
}
