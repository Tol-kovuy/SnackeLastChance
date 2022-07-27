using System;

namespace Snake
{
    public class Banner
    {
        public Banner(Coordinate position)
        {
            Position = position;
            Paint();
        }
        readonly string[] Logo = new string[] {
            @".-- -.         .       ,---.               ",
            @" \___  ,-. ,-. | , ,-. |  -'  ,-. ,-,-. ,-.",
            @"     \ | | ,-| |<  |-' |  ,-' ,-| | | | |-'",
            @" `---' ' ' `-^ ' ` `-' `---|  `-^ ' ' ' `-'",
            @"                        ,-.|               ",
            @"                        `-+'               "
        };

        ConsoleColor Color = ConsoleColor.Red;
        Coordinate Position = new Coordinate(1, 1);

        public void Paint()
        {
            Console.ForegroundColor = Color;
            for (int i = 0; i < Logo.Length; i++)
            {
                Console.SetCursorPosition(Position.X, Position.Y + i);
                Console.Write(Logo[i]);
            }
        }
    }
}
