string[] fraudulentIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
foreach (string ids in fraudulentIDs)
{
    if (ids.StartsWith("B"))
    {
        Console.WriteLine(ids);
    }
}
// this code will not work //