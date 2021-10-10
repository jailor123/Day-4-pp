static void Main(string[] args)
            Console.WriteLine();
            Console.WriteLine("Single Player mode: Starting position 0");  //as per UC1
            Console.WriteLine("....Game Begins....");

            //Variables
            int position = 0;
            int dice;


            Random die = new Random();
            int dice = die.Next(1, 7);
            Console.WriteLine("The number on this die roll is: "+dice);

        }
    }
}
