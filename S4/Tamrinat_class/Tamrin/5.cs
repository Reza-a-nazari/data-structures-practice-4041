public class Program
{
    public static void Main1(string [] args)
    {
        int n = 10;
        for(int i=n; i >0; i /=2)
        {
            for(int j = 1; j<n;j*=2)
            {
                for(int k =0; k<j; k+=2)
                {
                    System.Console.WriteLine("*");
                }
            }
        }
    }
}