using System;
using System.Collections.Generic;

namespace FruitsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> fruit = new Dictionary<string, double>();
            string answer = string.Empty;

            fruit.Add("apples", 0.99);
            fruit.Add("oranges", 0.50);
            fruit.Add("bananas", 0.50);
            fruit.Add("grapes", 2.99);
            fruit.Add("blueberries", 1.99);

            foreach (var item in fruit)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine("\nWhat fruit do you want?");
            answer = Console.ReadLine().ToLower().Trim();
            
            foreach (var item in fruit)
            {
                if (item.Key == answer)
                {
                    Console.WriteLine(item.Value.ToString("C"));
                }
            }
        }
    }
}
