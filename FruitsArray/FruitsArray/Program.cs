using System;

namespace FruitsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = { "apples", "oranges", "banana", "grapes", "blueberries" };
            double[] price = { 0.99, 0.50, 0.50, 2.99, 1.99 };
            string answer = string.Empty;

            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nWhat fruit do you want?");
            answer = Console.ReadLine().ToLower();

            if (answer == "apples")
            {
                Console.WriteLine($"The price of apples are {price[0].ToString("C")}");
            }
            else if (answer == "oranges")
            {
                Console.WriteLine($"The price of oranges are {price[1].ToString("C")}");
            }
            else if (answer == "banana")
            {
                Console.WriteLine($"The price of banana are {price[2].ToString("C")}");
            }
            else if (answer == "grapes")
            {
                Console.WriteLine($"The price of grapes are {price[3].ToString("C")}");
            }
            else if (answer == "blueberries")
            {
                Console.WriteLine($"The price of oranges are {price[4].ToString("C")}");
            }
            else
            {
                Console.WriteLine("The fruit you enter does not exist. Please try agian!");
            }
        }
    }
}
