//O(n^2)

#include <iostream>

using namespace std ;

int main()
{
    int arr[] = {1,99,-3,0,100,8,2};

    int size_arr = sizeof(arr)/sizeof(arr[0]);
    for(int i=0 ; i<size_arr-1 ; i++)
    {
        for(int j= 0 ; j<size_arr-i-1 ;j++)
        {
            if(arr[j]>arr[j+1])
            {
                int temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp ;
            }
        }
    }

    for(int x =0 ; x<size_arr ;x++)
    {
        cout<<arr[x]<<" ";
    }
}