#include <stdio.h>
#include <string.h>
#include <ctype.h>
int main()
{
    char name[23];

    printf("Enter your name: ");
    fgets(name, sizeof(name), stdin);
    name[strcspn(name, "\n")] = '\0';

    for (int i = 0; i < strlen(name); i++)
    {
        name[i] = tolower(name[i]);
    }

    printf("%s", name);
}