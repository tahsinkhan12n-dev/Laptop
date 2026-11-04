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

PrintInterEmail(corporate);
PrintExterEmail(external);

void PrintExterEmail(string[,] externalEmply)
{
    string[] email = new string[externalEmply.GetLength(0)];

    for (int i = 0; i < externalEmply.GetLength(0); i++)
    {
        string firstTwo = externalEmply[i, 0].Substring(0, 2).ToLower();

        email[i] = $"{firstTwo}{externalEmply[i, 1].ToLower()}@{externalDomain}";
    }

    for (int i = 0; i < email.GetLength(0); i++) 
    {
        // display external email addresses
        Console.WriteLine(email[i]);
    }
}

void PrintInterEmail(string[,] internalEmply, string Internaldomain = "contoso.com")
{
    string[] email = new string[internalEmply.GetLength(0)];

    for (int i = 0; i < internalEmply.GetLength(0); i++)
    {
        string firstTwo = internalEmply[i, 0].Substring(0, 2).ToLower();
        
        email[i] = $"{firstTwo}{internalEmply[i, 1].ToLower()}@{Internaldomain}";
    }

    for (int i = 0; i < email.GetLength(0); i++) 
    {
        // display internal email addresses
        Console.WriteLine(email[i]);
    }
}