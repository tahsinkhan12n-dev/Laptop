using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100];
int[] andrewScores = [92, 89, 81, 96, 90];
int[] emmaScores = [90, 85, 87, 98, 68];
int[] loganScores = [90, 95, 87, 88, 96];

string[] studentName = ["Sophia", "Andrew", "Emma", "Logan"];
int[] studentScores = new int[10];

string currentStudentletterGread = "";

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
    decimal currnetStudentGread = 0;

    foreach (int score in studentScores)
    {
        studentSum += score;
    }
    currnetStudentGread = (decimal)studentSum / currentAssignments;

    if (currnetStudentGread >= 97)
        currentStudentletterGread = "A+";
    if (currnetStudentGread >= 93)
        currentStudentletterGread = "A";
    if (currnetStudentGread >= 90)
        currentStudentletterGread = "A-";
    if (currnetStudentGread >= 87)
        currentStudentletterGread = "B+";
    if (currnetStudentGread >= 83)
        currentStudentletterGread = "B";
    if (currnetStudentGread >= 80)
        currentStudentletterGread = "B-";
    if (currnetStudentGread >= 77)
        currentStudentletterGread = "C+";
    if (currnetStudentGread >= 73)
        currentStudentletterGread = "C";
    if (currnetStudentGread >= 70)
        currentStudentletterGread = "C-";
    if (currnetStudentGread >= 67)
        currentStudentletterGread = "D+";
    if (currnetStudentGread >= 63)
        currentStudentletterGread = "D";
    if (currnetStudentGread >= 60)
        currentStudentletterGread = "D-";
   else
       currentStudentletterGread = "F";

    Console.WriteLine($"{currentStudent}\t\t{currnetStudentGread}\t?");
}

