def insertion_sort(A):
    print(A)
    length = len(A)
    for i in range(1,length):
        key = A[i]
        j = i-1

        while (j>=0) and (A[j]>key):
            A[j+1] = A[j]
            print(A)
            j=j-1
        A[j+1] = key
        print(A)
    

    