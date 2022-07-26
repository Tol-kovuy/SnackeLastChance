using System;

namespace SnackeLastChance
{
    public class Teacher
    {
        public static void ToDrawBrickInTheWall()
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
    }
}
