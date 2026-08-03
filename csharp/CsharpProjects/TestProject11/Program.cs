string? roles;
string role;
bool valid = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    roles = Console.ReadLine();
    role = (roles ?? "").Trim().ToLower();
 
    if (role == "administrator" || role == "manager" || role == "user")
        valid = true;
    else
        Console.WriteLine($"The role name that you entered, \"{role}\" is not valid.");
} while (valid == false);

if (valid == true)
    Console.WriteLine($"Your input value {role} has been accepted.");