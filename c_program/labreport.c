#include <stdio.h>
int main()
{
    float sub_mark, total_mark = 0, avg_mark;

    for (int i = 1; i <= 5; i++)
    {
        printf("Enter your marks of subject %d: ", i);
        scanf("%f", &sub_mark);
        
        while (sub_mark > 100)
        {
            printf("Invalid mark, Please enter again: ");
            scanf("%f", &sub_mark);
        }

        total_mark = total_mark + sub_mark;
    }

    avg_mark = total_mark / 5;

    printf("\nThe aggregate mark is: %.1f\n", total_mark);
    printf("The average mark is: %.2f", avg_mark);
}
