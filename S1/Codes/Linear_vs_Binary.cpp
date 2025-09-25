#include <iostream>
#include <vector>
#include <chrono>

using namespace std ;
using namespace std::chrono;

int main()
{
    vector<int> array_of_testing(1000000000);

    for(int i=0 ; i<1000000000 ; i++)
    {
        array_of_testing[i] =  i+1 ;
    }

    int number = 674221232 ;

    auto start1 = high_resolution_clock::now();


    int index = 0 ;
    //Linear
    for(int i=0 ; i<1000000000;i++)
    {
        if(array_of_testing[i] == number)
        {
            index = i ;
            break;
        }
    }

    auto stop1 = high_resolution_clock::now();

    auto duration1 = duration_cast<microseconds>(stop1-start1);

    cout<<"Linear search found at index : " << index << " in " << duration1.count()<<" microseconds" <<endl; 




    //binary

    auto start2 = high_resolution_clock::now();

    int n = 1000000000;
    int left = 0 ;
    int right = n-1 ;

    while(left<=right)
    {
        int mid = left + (right-left)/2 ;
        if(array_of_testing[mid]==number)
        {
            index = mid ;
            break;
        }
        else if (array_of_testing[mid]<number)
        {
            left = mid +1 ;
        }
        else
        {
            right = mid -1 ;
        }
    }

    auto stop2 = high_resolution_clock::now();

    auto duration2 = duration_cast<nanoseconds>(stop2-start2);

    cout<<"binarySearch" <<index << " in "<<duration2.count()<<" nanosecond "<<endl;
}