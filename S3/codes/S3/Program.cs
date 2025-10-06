namespace S3;

class Program
{
    static void Main(string[] args)
    {
            int[] A = { 5, 2, 8, 3, 1, 7 };

            Console.WriteLine("Before sorting:");
            Console.WriteLine(string.Join(", ", A));

            MergeSort(A, 0, A.Length - 1);

            Console.WriteLine("After sorting:");
            Console.WriteLine(string.Join(", ", A));
    }


    public static void MergeSort(int[] A, int left, int right)
    {
        int mid = (left + right) / 2;

        if (left >= right)
        {
            return;
        }
        MergeSort(A, left, mid);
        MergeSort(A, mid + 1, right);

        Merge(A,left,mid,right);
    }

    public static void Merge(int[] A, int left, int mid, int right)
    {
            int n1 = mid - left + 1; // length of left part
            int n2 = right - mid;   //length of right part

            int[] Left = new int[n1];
            int[] Right = new int[n2];

            for (int i = 0; i < n1; i++)
                Left[i] = A[left + i];

            for (int j = 0; j < n2; j++)
                Right[j] = A[mid + 1 + j];

            int ii = 0;
            int jj = 0;
            int k = left;

            while (ii < n1 && jj < n2)
            {
                if (Left[ii] <= Right[jj])
                {
                    A[k] = Left[ii];
                    ii++;
                }
                else
                {
                    A[k] = Right[jj];
                    jj++;
                }
                k++;
            }

            while (ii < n1) //for remain left part
            {
                A[k] = Left[ii];
                ii++;
                k++;
            }

            while (jj < n2)   //for remain right part
            {
                A[k] = Right[jj];
                jj++;
                k++;
            }
    }
}
