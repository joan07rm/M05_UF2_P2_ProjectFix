using System;
using System.Collections.Generic;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unordered list: ");
            List<int> list = new List<int>(100);
            for (int i = 0; i < 100; i++)
            {
                list.Add(Utils.random.Next());
                Console.WriteLine(list[i]);
            }

            list = Sort(list);
            Console.WriteLine("Ordered list: ");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        static public List<int> Sort(List<int> list)
        {
            if (list.Count <= 1)
                return list;
            int pivot = list.Count / 2;
            int pivotValue = list[pivot];
            list.RemoveAt(pivot);
            List<int> smaller = new List<int>();
            List<int> greater = new List<int>();
            foreach (int element in list)
            {
                if (element <= pivotValue)
                    smaller.Add(element);
                else
                    greater.Add(element);
            }
            List<int> sorted = new List<int>();
            sorted.AddRange(Sort(smaller));
            sorted.Add(pivotValue);
            sorted.AddRange(Sort(greater));
            return sorted;
        }
    }
}
