/*
string first = "Hello";
string second = "world";
//string result = string.Format("{1} {0}!", first, second);
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{first} {first}!");
Console.WriteLine($"{first} {first} {first}!");


decimal price = 68.89m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
yourDiscount += $"A discount of {((price - salePrice) / price):P2}!";
Console.WriteLine(yourDiscount);

decimal tax = .12051m;
Console.WriteLine($"Tax rate: {tax:P1}");


int invoiceNumber = 1201;
decimal productShares = 25.54367m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15824m;
decimal total = 3185.18m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"    Shares: {productShares:N3} Product");
Console.WriteLine($"        Sub Total: {subtotal:C}");
Console.WriteLine($"            Tax: {taxPercentage:P2}");
Console.WriteLine($"    Total Billed: {total:C}");



string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

*/

string input = "Pad this";
Console.WriteLine(input.PadRight(12));