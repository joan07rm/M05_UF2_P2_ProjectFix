using System;
using System.Collections.Generic;

namespace Factorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want?");
            ulong num_ammount;
            string response = Console.ReadLine();
            num_ammount = ulong.Parse(response);
            Random gen = new Random();
            List<float> numbers = new List<float>();
            for (ulong i = 0; i < num_ammount; i++)
            {
                numbers.Add(gen.Next(20));
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Average: " + average(numbers));

            Console.WriteLine("Factorial for: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(factorial_for((ulong)numbers[i]));
            }

            Console.WriteLine("Factorial recursive: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(factorial_recursive((ulong)numbers[i]));
            }
        }

        public static float average(List<float> numbers)
        {
            float sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        public static ulong factorial_recursive(ulong n)
        {
            if (n < 1)
            {
                return 1;
            }
            return n * factorial_recursive(n - 1);
        }

        public static ulong factorial_for(ulong n)
        {
            ulong res = 1;
            for (ulong i = 2; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}
