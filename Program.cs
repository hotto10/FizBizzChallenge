using System;

namespace FizzBizzChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number to see if divisible by 3 or 5");
            var number = int.Parse(Console.ReadLine());
            GetFuzzBuzz(number);
        }

        public static string GetFuzzBuzz(int number)
        {
            var word = "";

            if (number % 3 == 0)
            {
                word = "fizz";
            }

            if (number % 5 == 0)
            {
                word += "buzz";
            }

            Console.WriteLine(word);
            return word;

        }

    }
}
