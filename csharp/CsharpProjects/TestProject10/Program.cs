using System.Text.Json.Serialization;

int number;
string? input;
bool valid = false;

Console.Write("Enter a number between 5 to 10: ");

do
{
    input = Console.ReadLine();
    int.TryParse(input, out number);

    if (number < 5 || number > 10)
        Console.WriteLine("Enter a int in rang of 5 to 10: ");
    else
        valid = true;
} while (valid == false);

if (valid == true)
    Console.WriteLine($"Your input value ({number}) has been accepted.");