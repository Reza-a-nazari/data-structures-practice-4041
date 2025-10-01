namespace CSHARP_TRAINING;
//linked list
//array
//queue
//stack
//list
using System.Diagnostics;
public class Codes
{
    public static void Main1(string[] args)
    {
        // System.Console.WriteLine("Hello");

        Stopwatch Time1 = new Stopwatch();

        Time1.Start();

        adding(100000);

        Time1.Stop();

        Stopwatch Time2 = new Stopwatch();

        Time2.Start();

        addinglinkedList(100000);

        Time2.Stop();

        System.Console.WriteLine(Time1.ElapsedMilliseconds.ToString());
        System.Console.WriteLine(Time2.ElapsedMilliseconds.ToString());

    }


    public static int[] adding(int n)
    {
        int[] final = new int[n];

        for (int i = 1; i < n; i++)
        {
            final[i] += i;
        }

        return final;
    }


    public static LinkedList<int> addinglinkedList(int n)
    {
        LinkedList<int> final = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            final.AddLast(i);
        }
        return final;
    }
}