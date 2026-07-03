using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophia = [90, 86, 87, 98, 100];
int[] andrew = [92, 89, 81, 96, 90];
int[] emma = [90, 85, 87, 98, 68];
int[] logan = [90, 95, 87, 88, 96];

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

foreach (int gread in sophia)
{
    sophiaSum = sophiaSum + gread;
    sophiaScore = (decimal)sophiaSum / currentAssignments;
}

foreach (int gread in andrew)
{
    andrewSum = andrewSum + gread;
    andrewScore = (decimal)andrewScore / currentAssignments;
}

foreach (int gread in emma)
{
    emmaSum = emmaSum + gread;
    emmaScore = (decimal)emmaScore / currentAssignments;
}

foreach (int gread in logan)
{
    loganSum = loganSum + gread;
    loganScore = (decimal)loganScore / currentAssignments;
}
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
//Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
//Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
//Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
