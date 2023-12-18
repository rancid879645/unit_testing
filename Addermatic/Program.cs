// See https://aka.ms/new-console-template for more information

using Addermatic;

Console.WriteLine("Welcome to Addermatic.");
Console.WriteLine("first operand: ");
var operandA =Console.ReadLine();
Console.WriteLine("Second operand: ");
var operandB = Console.ReadLine();

var calc = new Calculator(operandA, operandB);
Console.WriteLine($"Result: {calc.SumOperands()}");