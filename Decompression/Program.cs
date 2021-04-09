using System;
using System.Collections.Generic;

namespace Decompression
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] DecodeMe = { 4, 5, 4, 10, 2, 5 };
            //Decompress(DecodeMe);
            int[] DecodeMe2 = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
            //Decompress(DecodeMe2);
            int[] DecodeMe3 = { 5, 1, 4, 2, 3, 3, 2, 4, 1, 5 };
            Decompress(DecodeMe3);

        }

        public static int[] Decompress(int[] nums)
        {
            var Another = new List<int>();
            for (var i = 0; i < nums.Length; i += 2)
            {
                var count = nums[i];
                var toDup = nums[i + 1];
                while (count-- > 0)
                {
                    Another.Add(toDup);
                }
            }
            foreach (int x in Another)
            {
                Console.Write($"{x}, ");
            }
            return Another.ToArray();
        }
    }
}

