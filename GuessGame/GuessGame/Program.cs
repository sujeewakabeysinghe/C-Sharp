using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "sujeewa";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuess = false;
            while (guess!=word && !outOfGuess)
            {
                if (guessCount<guessLimit)
                {
                    Console.Write("what is the name : ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuess = true;
                }
            }
            if (outOfGuess)
            {
                Console.WriteLine("you lose!");
            }
            else
            {
                Console.WriteLine("you won!");
            }
            

            Console.ReadLine();
        }
    }
}
