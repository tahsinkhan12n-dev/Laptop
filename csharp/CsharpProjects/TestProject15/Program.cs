// sorted array small to big

string[] pallets = ["B21", "A11", "B34", "B33"];
/*
Console.WriteLine("Sorted....");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// reversed sorted array

Console.WriteLine("");
Console.WriteLine("Reversed....");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
//  clear

Console.WriteLine("");

Array.Clear(pallets, 0 , 2);
Console.WriteLine($"Clearing 2 .... count: {pallets.Length}");
foreach (var pallet in pallets)
    Console.WriteLine($"-- {pallet}");

Console.WriteLine("");

Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");

Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets}");
foreach (var pallet in pallets)
    Console.WriteLine($"-- {pallet}");