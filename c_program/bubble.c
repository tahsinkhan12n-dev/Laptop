#include <stdio.h>
#include <stdbool.h>

void printArray(int arr[], int size);
int main()
{
    int n = 10;
    int arr[n];

    for (int i = 0; i < n; i++)
    {
        printf("Insert a eliment: ");
        scanf("%d", &arr[i]);
    }

    // printing the array
    printf("Unsorted array: ");
    printArray(arr, n);

    printf("\n\n");

    for (int i = 0; i < n - 1; i++)
    {
        bool swaped = false;
        printf("Pass %d:\n", i+1);
        for (int j = 0; j < n - i - 1; j++ )
        {
            if (arr[j] > arr[j+1])
            {
                int tmp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = tmp;
                swaped = true;
            }
            //printArray(arr, n);
            
            printArray(arr, n);
            if (swaped == true)
                printf("[SWAPED]");
            printf("\n");
        }
        
        if (!swaped)
        {
            break;
        }
    }

    //print the sorted array
    printf("The sorted array: ");
    printArray(arr, n);
}

void printArray(int arr[], int size)
{
    for (int i = 0; i < size; i++)
    {
        printf("%d ", arr[i]);
    }
}