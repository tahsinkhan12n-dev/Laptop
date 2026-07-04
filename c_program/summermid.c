#include <stdio.h>

int main()
{
    int n, mark, total_mark = 0;

    printf("Number of subjects: ");
    scanf("%d", &n);

    if (n < 2)
    {
        printf("Number of sub must be greater than 2:");
        scanf("%d", &n);
    }

    for (int i = 0; i < n; i++)
    {
        printf("Subject Scores: ");
        scanf("%d", &mark);

        if (mark < 0 || mark > 100)
        {
            printf("Invalid Score, Enter again: ");
            scanf("%d", &mark);
        }

        total_mark = total_mark + mark;
    }

    float avg = (1.0) * total_mark / n;

    if (avg >= 80)
    {
        printf("Average Gread: A+");
    }
    else if (avg >= 70 && avg < 80)
    {
        printf("Average Gread: A");
    }
    else if (avg >= 60 && avg < 70)
    {
        printf("Average Gread: B");
    }
    else if (avg >= 50 && avg < 60)
    {
        printf("Average Gread: C");
    }
    else if (avg >= 40 && avg < 50)
    {
        printf("Average Gread: D");
    }
    else
    {
        printf("Average Gread: F");
    }
}