using System;

namespace task_3_assigment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let play on fruit machine");

            var random = new Random();
            int result = 0;
            Console.WriteLine("Please enter to Spin. Type \"quit \" to exit the game");
            
            while (true)
            {
                int x = random.Next(0, 10);
                int y = random.Next(0, 10);
                int z = random.Next(0, 10);

                string unput = Console.ReadLine();
                unput.ToLower();

                if (unput == "quit")
                {
                    break;
                }

                    Console.WriteLine("{0},{1},{2}, x,y,z");


                if (x == y && y == z && x == 9)
                {
                    result += 2000;
                    Console.WriteLine("You win 2000 credit.\n New result is {0}", result);
                }
                else if ((x == y && x == 9) || (y == z && y == 9) || (x == z && x == 9))
                {
                    result += 200;
                    Console.WriteLine("Your score 200 points.\n New results is {0}", result);
                }
                else if (x == y && y == z)
                {
                    result += 15;
                    Console.WriteLine("Your score is 15 points.\n New result is {0}", result);
                }
                else if (x == y || y == z || x == 9 )
                {
                    result += 5;
                    Console.WriteLine("Your score is 5 points.\n New result is {0}", result );
                }
                else
                {
                    Console.WriteLine("You lost the game");
                    
                }
                

            }





        }
    }
}   

