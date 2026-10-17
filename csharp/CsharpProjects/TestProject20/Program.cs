using System.Data.SqlTypes;

string ipv4Input = "107.31.1.5";
bool validLength = false;
bool validZeros = false;
bool validRange = false;

ValidateLength();
ValidateZeros();
ValidateRange();

if (validLength && validZeros && validRange)
{
    Console.WriteLine($"ip is a valid IPv4 address");
}
else
{
    Console.WriteLine($"ip is invalid IPv4 address");
}


void ValidateLength()
{
    string[] address = ipv4Input.Split(".");
    validLength = address.Length == 4;
}

void ValidateZeros()
{
    string[] address = ipv4Input.Split(".");

    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeros = false;
            return;
        }
    }
    validZeros = true;
}

void ValidateRange()
{
    string[] address = ipv4Input.Split(".", StringSplitOptions.RemoveEmptyEntries);

    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}