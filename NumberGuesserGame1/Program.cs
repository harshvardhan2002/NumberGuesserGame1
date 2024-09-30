namespace NumberGuesserGame1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secretNumber;

            int minRange, maxRange;

            Console.WriteLine("Enter the minimum range: ");
            minRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum range: ");
            maxRange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the secret number: (within the range)");
            secretNumber = Convert.ToInt32(Console.ReadLine());

            NumberGuesser numberGuesser = new NumberGuesser(minRange, maxRange, secretNumber);

            numberGuesser.StartGuessing();
        }
    }
}
