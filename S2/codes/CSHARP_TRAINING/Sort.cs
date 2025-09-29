namespace CSHARP_TRAINING;
using System.Diagnostics;
using System.Collections.Generic;



public class Sort
{
    public static void Main(string[] args)
    {

        // System.Console.WriteLine("This program take a long , please wait...!");

        //     Random rnd = new Random();

        //     int[] numming = new int[100000];
        //     for (int i = 0; i < numming.Length; i++)
        //     {
        //         numming[i] = rnd.Next(-100000, 100001);
        //     }



        // Stopwatch t1 = new Stopwatch();

        // t1.Start();

        // int[] mynum = Bubble_Sort(numming);

        // t1.Stop();

        // System.Console.WriteLine("The time span is : " + t1.ElapsedMilliseconds.ToString() + " millisecond" + " Bubble sort");


        // Stopwatch t2 = new Stopwatch();
        // List<int> nums = new List<int>(numming);


        // t2.Start();

        // List<int> Ans = Selection_Sort(nums);

        // // foreach (var i in Ans)
        // // {
        // //     System.Console.WriteLine(i);
        // // }

        // t2.Stop();

        // System.Console.WriteLine("The time span is : " + t2.ElapsedMilliseconds.ToString() + " millisecond" + " Selection sort");


        int[] answer = Insertion_Sort(new int[] { 11, 0, 3, -2, 8, 14 });

        foreach (var i in answer)
        {
            System.Console.Write(i+ " ");
        }

    }

    public static int[] Bubble_Sort(int[] nums)
    {

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    int temp = nums[j];

                    nums[j] = nums[j + 1];

                    nums[j + 1] = temp;
                }
            }
        }
        return nums;
    }

    public static List<int> Selection_Sort(List<int> nums)
    {
        List<int> final = new List<int>();


        while (nums.Count > 0)
        {
            int min = nums[0];

            int MinIndex = 0;

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                    MinIndex = i;
                }
            }

            final.Add(min);

            nums.RemoveAt(MinIndex);
        }
        return final;
    }

    public static int[] Insertion_Sort(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            int key = nums[i];
            int j = i - 1;

            while ((j >= 0) && (nums[j] > key))
            {
                nums[j + 1] = nums[j];
                j--;
            }
            nums[j + 1] = key;
        }
        return nums;
    }


    // public static int[] Merge_Sort(int[] nums)
    // {

    // }
    

}