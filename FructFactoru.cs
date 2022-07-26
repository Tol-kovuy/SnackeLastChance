using System;
using System.Collections.Generic;
using System.Text;

namespace SnackeLastChance
{
    public class FructFactoru
    {
        public static void ToCreateTheFruict()
        {
            bool appleFaund = false;

            for (int i = 0; i < GameSettings.BackGroundField.GetLength(0); i++)
            {
                for (int j = 0; j < GameSettings.BackGroundField.GetLength(1); j++)
                {
                    if (GameSettings.BackGroundField[i, j] == -1)
                    {
                        appleFaund = true;
                    }
                }
            }
            if (appleFaund == false)
            {
                Random rand = new Random();
                int x = rand.Next(1, GameSettings.BackGroundField.GetLength(0) - 1);
                int y = rand.Next(1, GameSettings.BackGroundField.GetLength(1) - 1);

                GameSettings.BackGroundField[x, y] = -1;
                counter++;
            }
        }
    }
}
