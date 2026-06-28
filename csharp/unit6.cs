/*  
    This code reverses a message, counts the number of times
    a particular characte appears, then prints the results
    to the console window.
*/

string originalMessage = "The quick broun fox jumps over teeh lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
