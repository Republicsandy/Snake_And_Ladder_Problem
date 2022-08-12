using System;

namespace SnakeAndLedderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("1 for find the length of line");
            Console.WriteLine("2 for check the line is equal or not");

            int Option = Convert.ToInt32(Console.ReadLine());

            switch (Option)
            {

                case 1:
                    PlayerFirst qemrem = new PlayerFirst();
                    qemrem.Player1();
                    break;
                case 2:
                    PlayerSecond swapnum = new PlayerSecond();
                    swapnum.Player2();
                    break;
            }
        }
    }
}
