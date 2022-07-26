using System;

namespace SnackeLastChance
{
    public class Teacher
    {
        GameSettings gameSettings = new GameSettings();
        public void ToDrawBrickInTheWall()
        {
            Console.Clear();
            Console.CursorVisible = false;

            for (int i = 0; i < gameSettings.BackGroundField.GetLength(0); i++)
            {
                for (int j = 0; j < gameSettings.BackGroundField.GetLength(1); j++)
                {
                    if (gameSettings.BackGroundField[i, j] == 1)
                    {
                        Console.Write("█");
                    }

                    else if (gameSettings.BackGroundField[i, j] >= 2)
                    {
                        Console.Write("■");
                    }
                    else if (gameSettings.BackGroundField[i, j] == -1)
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
            Console.WriteLine(gameSettings.Counter);
        }
    }
}
