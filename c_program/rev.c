#include <stdio.h>
#include <string.h>

int main()
{
    char name[10];

    printf("Enter your name: ");
    scanf("%s", name);

    // with a loop
    // for (int i = strlen - 1; i >= 0; i--)
    //     printf("%c", name[i]);
    
    printf("%s", strrev(name));
}