using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100];
/*
int[] andrewScores = [92, 89, 81, 96, 90];
int[] emmaScores = [90, 85, 87, 98, 68];
int[] loganScores = [90, 95, 87, 88, 96];


int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;


decimal andrewScore;
decimal emmaScore;
decimal loganScore;

/*


foreach (int score in andrewScores)
{
    andrewSum += score;
}

andrewScore = (decimal)andrewSum / currentAssignments;

foreach (int score in emmaScores)
{
    emmaSum += score;
}

emmaScore = (decimal)emmaSum / currentAssignments;

foreach (int score in loganScores)
{
    loganSum += score;
}

loganScore = (decimal)loganSum / currentAssignments;
*/


string[] studentName = ["Sophia", "Andrew", "Emma", "Logan"];
int[] studentScores = new int[10];

foreach (string name in studentName)
{
    string currentStudent = name;
    if (currentStudent == "Sophia")
    {
        
        int sophiaSum = 0;
        decimal sophiaScore;
        foreach (int score in sophiaScores)
        {
            sophiaSum += score;
        }
        sophiaScore = (decimal)sophiaSum / currentAssignments;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
    }
}

/*


Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
*/
