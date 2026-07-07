using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];

string[] studentName = ["Sophia", "Andrew", "Emma", "Logan"];
int[] studentScores = new int[10];

string currentStudentletterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentName)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    }
    else if (currentStudent == "Emma")
    {
        studentScores = emmaScores;
    }
    else if (currentStudent == "Logan")
    {
        studentScores = loganScores;
    }

    int studentSum = 0;
    decimal currnetStudentGrade = 0;

    int count = 0;

    foreach (int score in studentScores)
    {
        count++;

        if (count <= currentAssignments)
        {
            studentSum += score;
        }

        else
        {
            studentSum += score / 10;
        }
    }
    currnetStudentGrade = (decimal)studentSum / currentAssignments;

    if (currnetStudentGrade >= 97)
        currentStudentletterGrade = "A+";

    else if (currnetStudentGrade >= 93)
        currentStudentletterGrade = "A";

    else if (currnetStudentGrade >= 90)
        currentStudentletterGrade = "A-";

    else if (currnetStudentGrade >= 87)
        currentStudentletterGrade = "B+";

    else if (currnetStudentGrade >= 83)
        currentStudentletterGrade = "B";

    else if (currnetStudentGrade >= 80)
        currentStudentletterGrade = "B-";

    else if (currnetStudentGrade >= 77)
        currentStudentletterGrade = "C+";

    else if (currnetStudentGrade >= 73)
        currentStudentletterGrade = "C";

    else if (currnetStudentGrade >= 70)
        currentStudentletterGrade = "C-";

    else if (currnetStudentGrade >= 67)
        currentStudentletterGrade = "D+";

    else if (currnetStudentGrade >= 63)
        currentStudentletterGrade = "D";

    else if (currnetStudentGrade >= 60)
        currentStudentletterGrade = "D-";

    else
       currentStudentletterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currnetStudentGrade}\t{currentStudentletterGrade}");
}