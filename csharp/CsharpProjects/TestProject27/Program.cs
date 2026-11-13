Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play)
    {
        int target = random.Next(1, 6);
        var roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
        return "You Win!";
    else
        return "You lose!";
}

bool ShouldPlay()
{
    string? input;
    string choice = "";
    do
    {
        input = Console.ReadLine();
        if (input != null)
        {
            choice = input.Trim();
        }  
    } while (choice != "Y" && choice != "N");

    if (choice == "Y")
        return true;
    else
        return false;
}