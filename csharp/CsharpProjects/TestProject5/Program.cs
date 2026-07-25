int employeeLevel = 200;
string employeeName = "John Smith";

string titel = "";

switch (employeeLevel)
{
    case 100:
        titel = "Junior Associate";
        break;
    case 200:
        titel = "Senior Associate";
        break;
    case 300:
        titel = "Manager";
        break;
    case 400:
        titel = "Senior Manager";
        break;
    default:
        titel = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {titel}");