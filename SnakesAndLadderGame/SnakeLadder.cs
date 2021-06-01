using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLadderGame
{
    class SnakeLadder
    {
        public static int No_Play = 1;
        public static int Ladder = 2;
        public static int Snake = 3;

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
            Random ran = new Random();
            int option = 0;
            while (true)
            {
                option = ran.Next(4);
                if (option != 0) break;
            }
            Console.WriteLine("====OPTIONS======\nOption 1 : No Play\nOption 2 : Ladder \nOption 3 : Snake \n");
            Console.WriteLine("Option : " + option);

            switch (option)
            {
                case 1:
                    Console.WriteLine("Player stays in the same position : " + position);
                    break;

                case 2:
                    position += droll;
                    Console.WriteLine("Player moves ahead by : " + position);
                    break;

                case 3:
                    position -= droll;
                    Console.WriteLine("Player moves behind by : " + position);
                    break;
                default:
                    Console.WriteLine("Enter correct value");
                    break;

            }
        }
    }
}
