

namespace guess_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 0;
            int tryCount = 0;
            int gameCount = 0;
            Random random = new Random();
            ConsoleKeyInfo key;
            do
            {
                gameCount++;
                int number = random.Next(1, 101);
                int attemptCount = 0;
                while (true)
                {
                    attemptCount++;
                    Console.WriteLine("Enter your try in [1;100]");
                    int tries = 0;
                    while (!int.TryParse(Console.ReadLine(), out tries)
                        || tries < 1 || tries > 100)
                        Console.WriteLine("Error, Enter correct number in [1,100]");
                    if (tries > number)
                        Console.WriteLine("Your try is more");
                    else if (tries < number)
                        Console.WriteLine("Your try is less");
                    else
                    {
                        Console.WriteLine("You win");
                        break;
                    }
                }
                tryCount += attemptCount;
                if (max < attemptCount) max = attemptCount;

                min = min == 0 || min > attemptCount ? attemptCount : min;
                //if (min == 0 || min > attemptCount) min = attemptCount;

                Console.WriteLine("Enter Y if you want play again");
                key = Console.ReadKey();
            } while (key.Key == ConsoleKey.Y);
            Console.WriteLine($"Max = (max)\n Min = (min)\n Avg = (Convert.ToDouble tryCount/gameCount)");
        }
    }
}
