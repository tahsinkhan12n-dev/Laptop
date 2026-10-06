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


string input = "Pad this";
//Console.WriteLine(input.PadRight(12));
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));



string paymentId = "723C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";
var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadRight(10);
Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

*/

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine("As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine("");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
Console.WriteLine("");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potentia profit would be {newProfit:C2}");
Console.WriteLine("");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
comparisonMessage += $"{currentProduct.PadRight(20)} {currentReturn:P2}   {currentProfit:C2}\n{newProduct.PadRight(20)} {newReturn:P2}   {newProfit:C2}";


Console.WriteLine(comparisonMessage);