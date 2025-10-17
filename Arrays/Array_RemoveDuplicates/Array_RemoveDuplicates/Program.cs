using System;
public class Array_RemoveDuplicates
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int i = 0;
        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[j] != nums[i])
            {
                i++;
                nums[i] = nums[j];
            }
        }
        return i + 1;
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
        Console.WriteLine("Original array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
        Array_RemoveDuplicates obj = new Array_RemoveDuplicates();
        int k = obj.RemoveDuplicates(nums);
        Console.WriteLine($"Number of unique elements: {k}");
        Console.WriteLine("Array after removing duplicates:");
        for (int i = 0; i < k; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    }
}