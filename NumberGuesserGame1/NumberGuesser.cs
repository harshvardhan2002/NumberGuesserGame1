using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesserGame1
{
    class NumberGuesser
    {
        private int minRange;
        private int maxRange;
        private int secretNumber;

        public NumberGuesser(int minRange, int maxRange, int secretNumber)
        {
            this.minRange = minRange;
            this.maxRange = maxRange;
            this.secretNumber = secretNumber;
        }
        public void StartGuessing()
        {
            Console.Clear();
            Console.WriteLine("Range set by game master is " + minRange + "-" + maxRange);
            Console.WriteLine("Guess the number: ");

            int guessingNumber = Convert.ToInt32(Console.ReadLine());

            while (guessingNumber != secretNumber)
            {
                if (guessingNumber < secretNumber)
                {
                    Console.WriteLine("The number is too low. Try again!");
                }
                else
                {
                    Console.WriteLine("The number is too high. Try again!");
                }

                guessingNumber = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Congrats! The number is right!");
        }

    }
}
