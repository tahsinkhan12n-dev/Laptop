/*
string message = "hello there!";

int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");


string message = "(What if) there are (more than) one (set of parentheses)?";

while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
    
    message = message.Substring(closingPosition + 1);
}



string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = {'[', '{', '('};
int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbole = message.Substring(openingPosition, 1);

    char matchingSymbole = ' ';

    switch (currentSymbole)
    {
        case "[":
            matchingSymbole = ']';
            break;
        case "{":
            matchingSymbole = '}';
            break;
        case "(":
            matchingSymbole = ')';
            break;
    }

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbole, openingPosition);

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
*/


const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

int opening = input.IndexOf('5');
quantity = "Quantity: " + input.Substring(opening, 4);
output = input.Replace("<div>", "");
output = output.Replace("&trade;", "&reg;");
output = "Output: " + output.Replace("</div>", "");

Console.WriteLine(quantity);
Console.WriteLine(output);