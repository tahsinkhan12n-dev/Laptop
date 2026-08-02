string? readResult = "344";
int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);

Console.WriteLine(numericValue + 8);