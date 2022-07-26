namespace SnackeLastChance
{
    public class Snake
    {
        public static bool Up { get; set; }
        public static bool Down { get; set; }
        public static bool Right { get; set; }
        public static bool Left { get; set; }
        public static bool Alive { get; set; } = true;

        GameSettings GzameSettings = new GameSettings();

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

            if (Snake.Up)
            {
                if (GameSettings.BackGroundField[xHead - 1, yHead] > 0) Snake.Alive = false;
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

            else if (Snake.Down)
            {

                if (GameSettings.BackGroundField[xHead + 1, yHead] > 0) Snake.Alive = false;
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

            else if (Snake.Right)
            {
                if (GameSettings.BackGroundField[xHead, yHead + 1] > 0) Snake.Alive = false;
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
            else if (Snake.Left)
            {
                if (GameSettings.BackGroundField[xHead, yHead - 1] > 0) Snake.Alive = false;
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
