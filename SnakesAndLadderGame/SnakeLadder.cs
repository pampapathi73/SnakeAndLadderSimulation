using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadderGame
{
    class SnakeLadder
    {
        public void snake()
        {
            int position = 0;
            Console.WriteLine("Player is at position : " + position);
            Random random = new Random();
            int droll = 0;
            while (true)
            {
                droll = random.Next(6);
                if (droll != 0) break;

            }
            Console.WriteLine(droll);
        }
    }
}
