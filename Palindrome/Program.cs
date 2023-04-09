using System;
using System.Text;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a text");
            string response = Console.ReadLine();
            Console.WriteLine(Palindrome(response));
        }
        public static string Palindrome(string text)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(text);
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }

            return sb.ToString();
        }
    }
}
