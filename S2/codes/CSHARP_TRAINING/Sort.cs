namespace CSHARP_TRAINING;
using System.Diagnostics;



public class Sort
{
    public static void Main(string[] args)
    {

        int[] numming = { 1, -1, -4, 10, 11, 245 };

        int[] mynum = Bubble_Sort(numming);

        Stopwatch t1 = new Stopwatch();

        t1.Start();
        foreach (var i in mynum)
        {
            System.Console.WriteLine(i);
        }

        t1.Stop();

        System.Console.WriteLine("The time span is : " +t1.ElapsedMilliseconds.ToString() + " millisecond");

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

    // public static int[] Selection_Sort(int[] nums)
    // {

    // }

    // public static int[] Insertion_Sort(int[] nums)
    // {

    // }


    // public static int[] Merge_Sort(int[] nums)
    // {

    // }
    

}