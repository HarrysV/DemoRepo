using System;
using System.Collections.Generic;

namespace StaticUtilitiesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string c1 = "Kostas";
            string c2 = "Mitsos";

            Utilities.Swap( ref c1, ref c2);

            Console.WriteLine($"Swapped {c1} to {c2}");

            List<int> list = new List<int>() { 4, 4, 4, 4, 4, 5, 5, 5, 6, 6, 2, 6, 9 };
            List<int> listA = Utilities.Subsequence(list);

            foreach (var item in listA)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
