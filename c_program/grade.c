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

    getchar();

    student students[MAX];
    float gradePoint;
    float totalGradePoint = 0;

   

    for (int i = 0; i < MAX; i++)
    {
        printf("Name of student: ");
        fgets(students[i].studetName, 30, stdin);
        students[i].studetName[strcspn(students[i].studetName, "\n")] = '\0';

        getchar();

        printf("Enter your student Id last 3 digit: ");
        scanf("%d", &students[i].id);


        for (int j = 0; j < 4; j++)
        {
            printf("Enter student's grade point on subject %d: ", i + 1);
            scanf("%f", &gradePoint);

            totalGradePoint = totalGradePoint + gradePoint;
        }

        students[i].cgpa = (1.0) * totalGradePoint / 4;
    }
    
    printf("Student name\t\t\tStudent Id\t\tGrade");
    for (int k = 0; k < MAX; k++)
    {
        printf("\n%s\t\t\t%d\t\t%.2f\n", students[k].studetName, students[k].id, students[k].cgpa);
    }

    return 0;
}