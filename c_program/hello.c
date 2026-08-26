#include <stdio.h>
int main()
{
    char *sub[] = {"Physics", "Chemistry", "Biology", "Mathematics", "Computer"};
    int mark, totalMark = 0;

    for (int i = 0; i < 5; i++)
    {
        printf("Enter the mark of %s: ", sub[i]);
        scanf("%d", &mark);

        while (mark > 100 || mark < 0)
        {
            printf("Invalid mark, Enter again: ");
            scanf("%d", &mark);
        }

        totalMark = totalMark + mark;
    }

    float avgMark = totalMark / 5;

    if (avgMark >= 90)
        printf("Grade A");
    else if (avgMark >= 80)
        printf("Grade B");
    else if (avgMark >= 70)
        printf("Grade C");
    else if (avgMark >= 60)
        printf("Grade D");
    else if (avgMark >= 40)
        printf("Grade E");
    else if (avgMark < 40)
        printf("Grade F!!");

    return 0;
}