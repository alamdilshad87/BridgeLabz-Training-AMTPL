using System;
namespace Arrays
{
    public class Program
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { };
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array elements are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Enter target sum: ");
            int target = int.Parse(Console.ReadLine());
            Program obj = new Program();
            int[] result = obj.TwoSum(nums, target);
            if (result.Length == 2)
            {
                Console.WriteLine($"Indices found: {result[0]}, {result[1]}");
            }
            else
            {
                Console.WriteLine("No pair found.");
            }
        }
    }
}