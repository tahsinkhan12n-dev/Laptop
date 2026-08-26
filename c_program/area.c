#include <stdio.h>

int area(int weidth, int length);
int main()
{
    int w, l;
    printf("Enter weidth and length: ");
    scanf("%d %d", &w, &l);

    area(w, l);
}


int area(int weidth, int length)
{
    printf("%d Sq. unit", weidth * length);
}