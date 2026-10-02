/*
string value = "abc123";
char[] valueAarray = value.ToCharArray();
Array.Reverse(valueAarray);
//string result = new string(valueAarray);
string result = String.Join(" ", valueAarray);
Console.WriteLine(result);


string[] items = result.Split(' ');
foreach (string item in items)
    Console.WriteLine(item);


string pangram = "The quick brown fox jumps over the lazy dog";

char[] pangramArr = pangram.ToCharArray();
Array.Reverse(pangramArr);
string result = new string(pangramArr);
string[] arr = result.Split(' ');
Array.Reverse(arr);
string final = String.Join(" ",arr);
Console.WriteLine(final);
*/
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderID = orderStream.Split(',');
Array.Sort(orderID);
foreach (string id in orderID)
{
    if (id.Length == 4)
        Console.WriteLine(id);
    else
        Console.WriteLine(id + "\t- Error");
}

