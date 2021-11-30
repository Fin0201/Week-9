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
        }

        private static int LSearch(List<int> list, int itemToFind)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == itemToFind)
                    return i;
            }
            return -1;
        }
    }
}