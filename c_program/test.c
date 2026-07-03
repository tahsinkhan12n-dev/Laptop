#include <stdio.h>

int main()
{
    int bonusScore, preformenceScore, attendenceScore;

    printf("Enter Performence Score: ");
    scanf("%d", &preformenceScore);

    printf("Enter Attendence Score: ");
    scanf("%d", &attendenceScore);

    bonusScore = preformenceScore + attendenceScore - 10;

    if (bonusScore >= 85)
    {
        printf("Eligible for high bonus");
    }
    else if (bonusScore >= 60)
    {
        printf("Eligible for Medium bonus");
    }
    else
    {
        printf("No bonus");
    }

    return 0;
}