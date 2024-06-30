using System;

namespace PorjectOne
{
    class Program
    {

        void SumAvarage(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                
            }
            int ava = 0;
            ava = sum / nums.Length;

            Console.WriteLine($"The Sum of 10 Numbers is :{sum}");
            Console.WriteLine($"The Average is :{ava}");
        }

        static void Main(string[] args)
        {
            Program ojb = new();
            int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            ojb.SumAvarage(nums);


        }

    }
}

