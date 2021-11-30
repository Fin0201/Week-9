using System;
using System.Collections.Generic;


namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new ()
            {
                3,
                8,
                1,
                4,
                7,
                6,
                9,
                2,
                12,
                11,
                10,
                5
            };
            

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(LSearch(nums, 12));

            Console.WriteLine(BSearch(nums, 12, 0, 11));
        }

        private static int LSearch(List<int> list, int itemToFind)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == itemToFind)
                {
                    return i;
                }
            }
            return -1;
        }

        private static int BSearch(List<int> list, int itemToFind, int min, int max)
        {
            int midPoint = (min + max) / 2;
            
            if (list[midPoint] == itemToFind)
            {
                return midPoint;
            }
            else if (list[midPoint] < itemToFind)
            {
                BSearch(list, itemToFind, midPoint + 1, max);
            }
            else if (list[midPoint] > itemToFind)
            {
                BSearch(list, itemToFind, min, midPoint - 1);
            }
            else
            {
                return midPoint;
            }
            return -1;
        }
    }
}