#include <stdio.h>
#include <string.h>

typedef struct
{
    int id;
    char name[30];
} student;

int main()
{
    int MAX;
    printf("Enter number of students: ");
    scanf("%d", &MAX);

    student students[MAX];

    getchar();

    for (int i = 0; i < MAX; i++)
    {
        printf("Enter students Id: ");
        scanf("%d", &students[i].id);

        getchar();

        printf("Enter student name: ");
        fgets(students[i].name, 30, stdin);
        students[i].name[strcspn(students[i].name, "\n")] = '\0';
    }

    printf("\nID\t\tStudent name\n----------------------------------------\n");

    for (int i = 0; i < MAX; i++)
    {
        printf("%d\t\t%s\n", students[i].id, students[i].name);
    }

    return 0;
}