#include <stdio.h>
#include <string.h>

typedef struct
{
    float cgpa;
    char studetName[30];
    int id;
} student;

int main()
{
    int MAX;

    printf("Enter number of student: ");
    scanf("%d", &MAX);

    student students[MAX];
    int gradePoint;
    int totalGradePoint = 0;

   

    for (int i = 0; i < MAX; i++)
    {
        printf("Name of student: ");
        fgets(students[i].studetName, 30, stdin);
        students[i].studetName[strcspn(students[i].studetName, "\n")] = '\0';

        printf("Enter your student Id last 3 digit: ");
        scanf("%d", &students[i].id);


        for (int j = 0; j < 4; j++)
        {
            printf("Enter student's mark on subject %d", j + 1);
            scanf("%d", &gradePoint);

            totalGradePoint = totalGradePoint + gradePoint;
        }

        students[i].cgpa = (1.0) * totalGradePoint / 4;

        totalGradePoint = 0;
    }

    printf("Student name\t\t\tStudent Id\t\tGrade");
    for (int k = 0; k < MAX; k++)
    {
        printf("%s\t\t\t%d\t\t%.2f", students[k].studetName, students[k].id, students[k].cgpa);
    }

    return 0;
}