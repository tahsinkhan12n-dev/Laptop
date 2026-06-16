#include <stdio.h>

typedef struct
{
    int age;
    int citizen;
} voter;

int main()
{
    int MAX, i, count = 0;

    printf("Enter number of voter: ");
    scanf("%d", &MAX);

    voter voters[MAX];

    for (i = 0 ; i < MAX; i++)
    {
        printf("Enter age and citizenship(1/0): ");
        scanf("%d %d", &voters[i].age, &voters[i].citizen);
    }


    for (int j = 0; j < MAX; j++)
    {
        if (voters[j].age >= 18 && voters[j].citizen == 1)
        count++;
    }

    printf("Total eligible voters: %d", count);

    return 0;
}