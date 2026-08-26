#include <stdio.h>

int main()
{
    int unit;
    float payableTk;

    printf("Enter your unit consumption: ");
    scanf("%d", &unit);

    if (unit >= 601)
        payableTk = 390 + (1.0 * unit);
    else if (unit >= 401)
        payableTk = 230 + (0.80 * unit);
    else if (unit >= 201)
        payableTk = 100 + (0.65 * unit);
    else if (unit >= 0)
        payableTk = 0.50 * unit;

    printf("Total payableTk amount: %.2f Taka", payableTk);

    return 0;
}
