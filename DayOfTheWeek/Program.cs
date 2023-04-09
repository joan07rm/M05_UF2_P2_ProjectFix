using System;

namespace DayOfTheWeek
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a day");
            int day = int.Parse(Console.ReadLine());
            int dayofweek = DayOfTheWeek(year, month, day);
            Console.WriteLine("The day of the week is:");
            switch (dayofweek)
            {
                case 0: Console.WriteLine("Sunday"); break;
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                default: Console.WriteLine("Unknown"); break;
            }
        }
        public static int DayOfTheWeek(int year, int month, int day)
        {
            if (month < 3)
            {
                month += 12;
                year--;
            }
            int c = year / 100;
            int y = year % 100;
            int m = month;
            int d = day;
            int w = (int)((d + Math.Floor((13 * (m + 1)) / 5.0) + y + Math.Floor(y / 4.0) + Math.Floor(c / 4.0) + (5 * c)) % 7);
            return w - 1;

        }
    }
}

