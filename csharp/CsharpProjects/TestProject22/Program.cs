/*
int[] schedule = {800, 1200, 1600, 2000};


DisplayAdjustedTimes(schedule, 6, -6);





void DisplayAdjustedTimes(int[] times, int currentGTM, int newGTM)
{
    int diff = 0;
    if (Math.Abs(newGTM) > 12 || Math.Abs(currentGTM) > 12)
    {
        Console.WriteLine("Invalid GTM");
    }
    else if (newGTM <= 0 && currentGTM <= 0 || newGTM >= 0 && currentGTM >= 0)
    {
        diff = 100 * (Math.Abs(newGTM) - Math.Abs(currentGTM));
    }
    else
    {
        diff = 100 * (Math.Abs(newGTM) + Math.Abs(currentGTM));
    }
    for (int i = 0; i < times.Length; i++)
    {
        int newTime = (times[i] + diff) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}
*/
double pi = 3.14159;

PrintCircleInfo(12);

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area: {area}");
}

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}