using System;

namespace SnackeLastChance
{

    public class FructFactory
    {
        GameSettings gameSettings = new GameSettings();

        public void ToCreateTheFruict()
        {
            bool appleFaund = false;

            for (int i = 0; i < gameSettings.BackGroundField.GetLength(0); i++)
            {
                for (int j = 0; j < gameSettings.BackGroundField.GetLength(1); j++)
                {
                    if (gameSettings.BackGroundField[i, j] == -1)
                    {
                        appleFaund = true;
                    }
                }
            }
            if (appleFaund == false)
            {
                Random rand = new Random();
                int x = rand.Next(1, gameSettings.BackGroundField.GetLength(0) - 1);
                int y = rand.Next(1, gameSettings.BackGroundField.GetLength(1) - 1);

                gameSettings.BackGroundField[x, y] = -1;
                gameSettings.Counter++;
            }
        }
    }
}
