using System;

public class Mosalas
{
    public static void Main(string[] args)
    {
        string? inp = Console.ReadLine();
        if (string.IsNullOrEmpty(inp))
        {
            return;
        }

        int n = int.Parse(inp);
        long count = 0;
        for (int a = 1; a <= n / 3; a++)
        {
            int HB_paeen = Math.Max(a, n / 2 + 1 - a);
            int HB_bala = (n - a) / 2;
            if (HB_paeen <= HB_bala)
            {
                count += (long)HB_bala - HB_paeen + 1;
            }
        }

        Console.WriteLine(count);
    }
}




// توضیحات :D
// سلام به
// TA
// ها



// در مورد اینکه چرا فقط یک حلقه 
//for 
//نوشتیم
//به این خاطر بود که
//O(n)
//وگرنه اگر میخواستیم
//for ...
//  for ...
// آنوقت باید میگفتیم
//o(n^2)

//اما ما میخواهیم سرعت را به حداقل برسانیم 
// اما نمیتوانیم
//o(1)
// داشته باشیم
// پس باید
//O(n)
//باشد


//چون میخواهیم یک حلقه فور را پیمایش کنیم!
//


//!بازی ریاضی
//n = a + b + c
// شرط غیر تکراری
// a <= b <= c

// a + b> c
// a + c> b
// b + c> a

//  => bحد پایین برای 
//  b <=c
// => b<= n-a-b
// =  2b <= n-a
//  = b  <= n-a/2

//bحد بالا برای 
// a+b>c

// a+b>n-a-b
//
//
//2b > n-2a 
//
//
//
//

//b > n-2a /2

// if (HB_paeen <= HB_bala)
// {
//     count += (long)HB_bala - HB_paeen + 1;
// }



//این بررسی تعداد 
//b
// هایی است که می شود در معادله مثلث گذاشت
