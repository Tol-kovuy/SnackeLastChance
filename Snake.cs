namespace SnackeLastChance
{
    public class Snake
    {
        public static bool Up { get; set; }
        public static bool Down { get; set; }
        public static bool Right { get; set; }
        public static bool Left { get; set; }
        public static bool Alive { get; set; } = true;

        GameSettings gameSettings = new GameSettings();

        public  int ToCheckMaxValue()
        {
            int max = 0;

            for (int i = 0; i < gameSettings.BackGroundField.GetLength(0); i++)
            {
                for (int j = 0; j < gameSettings.BackGroundField.GetLength(1); j++)
                {
                    if (gameSettings.BackGroundField[i, j] > max)
                    {
                        max = gameSettings.BackGroundField[i, j];
                    }
                }
            }
            return max;
        }

        public void ToUpValueBody()
        {
            for (int i = 0; i < gameSettings.BackGroundField.GetLength(0); i++)
            {
                for (int j = 0; j < gameSettings.BackGroundField.GetLength(1); j++)
                {
                    if (gameSettings.BackGroundField[i, j] > 1)
                    {
                        gameSettings.BackGroundField[i, j]++;
                    }
                }
            }
        }
        public void ToDeleteMaxValue()
        {
            int max = 0;
            int x = 0;
            int y = 0;

            for (int i = 0; i < gameSettings.BackGroundField.GetLength(0); i++)
            {
                for (int j = 0; j < gameSettings.BackGroundField.GetLength(1); j++)
                {
                    if (gameSettings.BackGroundField[i, j] > max)
                    {
                        max = gameSettings.BackGroundField[i, j];
                        x = i;
                        y = j;
                    }
                }
            }

            gameSettings.BackGroundField[x, y] = 0;
        }

        public void ToMoveSnake()
        {

            int xHead = 0;
            int yHead = 0;

            for (int i = 0; i < gameSettings.BackGroundField.GetLength(0); i++)
            {
                for (int j = 0; j < gameSettings.BackGroundField.GetLength(1); j++)
                {
                    if (gameSettings.BackGroundField[i, j] == 2)
                    {
                        xHead = i;
                        yHead = j;
                    }
                }
            }

            if (Snake.Up)
            {
                if (gameSettings.BackGroundField[xHead - 1, yHead] > 0) Snake.Alive = false;
                else
                {
                    if (ToCheckMaxValue() > gameSettings.Counter)
                    {
                        ToDeleteMaxValue();
                    }

                    ToUpValueBody();
                    gameSettings.BackGroundField[xHead - 1, yHead] = 2;
                }

            }

            else if (Snake.Down)
            {

                if (gameSettings.BackGroundField[xHead + 1, yHead] > 0) Snake.Alive = false;
                else
                {
                    if (ToCheckMaxValue() > gameSettings.Counter)
                    {
                        ToDeleteMaxValue();
                    }

                    ToUpValueBody();
                    gameSettings.BackGroundField[xHead + 1, yHead] = 2;
                }
            }

            else if (Snake.Right)
            {
                if (gameSettings.BackGroundField[xHead, yHead + 1] > 0) Snake.Alive = false;
                else
                {
                    if (ToCheckMaxValue() > gameSettings.Counter)
                    {
                        ToDeleteMaxValue();
                    }

                    ToUpValueBody();
                    gameSettings.BackGroundField[xHead, yHead + 1] = 2;
                }
            }
            else if (Snake.Left)
            {
                if (gameSettings.BackGroundField[xHead, yHead - 1] > 0) Snake.Alive = false;
                else
                {
                    if (ToCheckMaxValue() > gameSettings.Counter)
                    {
                        ToDeleteMaxValue();
                    }

                    ToUpValueBody();
                    gameSettings.BackGroundField[xHead, yHead - 1] = 2;
                }
            }
        }
    }
}
