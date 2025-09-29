def merge_sort(A):
    mid = len(A)//2
    first_half = sorted(A[:mid])
    second_half = sorted(A[mid:])

    final = []

    i=j=0

    while i<len(first_half) and j<len(second_half):
        if first_half[i] <= second_half[j]:
            final.append(first_half[i])
            i+=1
        else:
            final.append(second_half[j])
            j+=1
    final.extend(first_half[i:])
    final.extend(second_half[j:])
    print(final)


merge_sort([100,1,24,5,6,-2,100000,23224])