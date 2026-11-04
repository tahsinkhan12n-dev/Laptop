// same problem with different approach

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
    PrintEmail(corporate[i, 0], corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    PrintEmail(external[i, 0], external[i, 1], domain: externalDomain);
}

void PrintEmail(string first, string last, string domain = "contoso.com")
{
    string email = first.Substring(0, 2) + last;
    Console.WriteLine($"{email.ToLower()}@{domain}");
}