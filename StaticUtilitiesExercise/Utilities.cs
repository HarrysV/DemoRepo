using System;
using System.Collections.Generic;
using System.Text;

namespace StaticUtilitiesExercise
{
    public static class Utilities
    {
        //swaps two integers
        public static void Swap (ref int num1,ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        //swaps any type of object
        public static void Swap<T>(ref T num1, ref T num2)
        {
            T temp = num1;
            num1 = num2;
            num2 = temp;
        }

        public static List<int> Subsequence(List<int> list)
        {
            int StartIndex = 0;
            int count = 1;
            int maxCount = 0;
            int maxStartIndex = 0;
           
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1] == list[i])
                {
                    count++;
                    if (i == list.Count - 1 && count > maxCount)
                    {
                        maxStartIndex = StartIndex;
                        maxCount = count;
                    }
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxStartIndex = StartIndex;
                    }
                    StartIndex = i;
                    count = 1;
                }

            }
            return list.GetRange(maxStartIndex, maxCount);
        }


    }
}
