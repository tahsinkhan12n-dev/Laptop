#include <stdio.h>

int main()
{
    int number;

    printf("Enter a number: ");
    scanf("%d", &number);

    if (number % 2 == 0)
        printf("\nEven nummber");
    else
        printf("\nOdd number");
    return 0;
}
