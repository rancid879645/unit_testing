using Addermatic;

Console.WriteLine("Welcome to Addermatic.");
Console.WriteLine("first operand: ");
var operandA =Console.ReadLine();
Console.WriteLine("Second operand: ");
var operandB = Console.ReadLine();

Console.WriteLine($"Result: {Calculator.Sum(operandA, operandB)}");