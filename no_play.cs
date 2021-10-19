using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

nameSpace ConsoleApp21
{
    class Program
    {
        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;

        static void Main(string[] args)
        {

            int p = 0;
            int ladderCount = 0;
            int snakeCount = 0;
            Console.WriteLine("game starts");
            Random r = new Random();
            int player = r.Next(0, 6) + 1;
            Console.WriteLine("The number is : " + player);
            Random b = new Random();
            int option = b.Next(0, 3) + 1;




            Random z = new Random();     
            Random options = new Random();
            int dice = z.Next(1, 7);       
            Console.WriteLine("The number on this die roll is: " + dice);
            int opt = options.Next(0, 3);   


            if (opt == NO_PLAY)
            {
                Console.WriteLine("No play: Player in same position " + p);
                Console.ReadLine();
            }
            else if (opt == LADDER)
            {
                p = p + dice;
                Console.WriteLine("Ladder is in  new postion " + p);
                Console.ReadLine();

            }
            else
            {
                p = p - dice;
                Console.WriteLine("snake is in new position  " + p);
                Console.ReadLine();
            }
        }
    }
}
