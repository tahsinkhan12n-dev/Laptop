#include <stdio.h>

int main()
{
    int balance = 1000, result;
    int survived = 1;

    for (int i = 1; i <= 5; i++)
    {
        printf("Round %d result (1 = Win, 0 = Lose): ", i);
        scanf("%d", &result);
        
        switch(result)
        {
            case 0:
                balance = balance - 500;

                if (balance <= 0)
                {
                    printf("Player Eliminated!\n");
                    printf("Balance reached 0");
                    survived = 0;
                    i = 6;
                }
                break;
            case 1:
                balance = balance + 500;

                if (balance <= 0)
                {
                    printf("Player Eliminated!\n");
                    printf("Balance reached 0");
                    survived = 0;
                    i = 6;
                }
                break;
            
        }
    }
    if (survived == 1)
    {
        printf("\nFinal balence: %d\n", balance);
        printf("Status: Survived!");
    }
}