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

 //new code

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

 // new code from here
int[] array = {1,2,3,4,5};


PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}

*/

string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca", 1, "none", true);
RSVP(name: "Nadia", partySize:  2, allergies: "Nuts", inviteOnly: true);
RSVP("Tony", inviteOnly: true, allergies: "NON", partySize: 9);
RSVP("Tahsin", 2, "non",false);
RSVP("Dev", inviteOnly: false);

ShowRSVPS();

void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string gest in guestList)
        {
            if (gest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPS()
{
    Console.WriteLine("\nTOtal RSVPS:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}