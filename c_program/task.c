#include <stdio.h>
#include <ctype.h>

int main()
{
    int baseSalary, grossSalary, pcSold, pcPrice, bonus;

    printf("Enter the number of computers sold: ");
    scanf("%d", &pcSold);
    printf("Enter the price of each computer: ");
    scanf("%d", &pcPrice);

    printf("Enter base salary: ");
    scanf("%d", &baseSalary);

    bonus = pcSold * 200 + ((pcPrice * pcSold) * 0.02);
    grossSalary = baseSalary + bonus;

    printf("\nGross Salary: %d", grossSalary);

    return 0;
}