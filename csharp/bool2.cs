string permission = "Admin|Manager";
int level = 65;

if (level > 55 && permission.Contains("Admin"))
{
    Console.WriteLine("Welcome, super Admin user.");
}

else if (level <= 55 && permission.Contains("Admin"))
{
    Console.WriteLine("Welcome, Admin user.");
}

else if (level >= 20 && permission.Contains("Manager"))
{
    Console.WriteLine("Contact an Admin for access.");
}

else if (level < 20 && permission.Contains("Manager"))
{
    Console.WriteLine("You do not have sufficient privileges.");
}

else if (!permission.Contains("Admin"))
{
    Console.WriteLine("You do not have sufficient privileges.");
}

else if (!permission.Contains("Manager"))
{
    Console.WriteLine("You do not have sufficient privileges.");
}