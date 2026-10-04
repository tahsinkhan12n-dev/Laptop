/*
string first = "Hello";
string second = "world";
//string result = string.Format("{1} {0}!", first, second);
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{first} {first}!");
Console.WriteLine($"{first} {first} {first}!");
*/

decimal price = 68.89m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
yourDiscount += $"A discount of {((price - salePrice) / price):P2}!";
Console.WriteLine(yourDiscount);

decimal tax = .12051m;
Console.WriteLine($"Tax rate: {tax:P1}");