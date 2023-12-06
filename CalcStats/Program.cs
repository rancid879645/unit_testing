using CalcStats;

try
{
    Console.WriteLine("Please digit the number separate by - without spaces");
    var numbers = Console.ReadLine();
    var numberOperations = new Operations(numbers);
    Console.WriteLine($"Min Value: {numberOperations.GetMinValue()}");
    Console.WriteLine($"Max Value: {numberOperations.GetMaxValue()}");
    Console.WriteLine($"Average: {numberOperations.GetAverageValue()}");
    Console.WriteLine($"Count: {numberOperations.CountElements()}");
}
catch (Exception e)
{
    Console.WriteLine(e);
}

