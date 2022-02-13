using System;

namespace SumTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3,2,3 };
            int target = 5;

            TwoSum(nums, target);
        }

        static void TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 0 || nums.Length == 0 || nums.Length < 2)
            {
                Console.WriteLine("Fuck");
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            Console.WriteLine("[" + nums[i] + " " + nums[j] + "]");
                        }
                    }
                }
            }               

        }
    }
}
