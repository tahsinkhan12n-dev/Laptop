#include <stdio.h>

int main()
{
    int i, total = 0, sell, n;

    printf("Enter days: ");
    scanf("%d", &n);
    for (i = 1; i <= n; i++)
    {
        printf("Enter total sell of day %d: ", i);
        scanf("%d", &sell);
        total = total + sell;   
    }

    printf("\nTotal sell of 7 days: %d", total);
}