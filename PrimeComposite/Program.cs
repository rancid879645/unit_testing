﻿// See https://aka.ms/new-console-template for more information

using PrimeComposite;

Console.WriteLine("From: ");
var from = Console.ReadLine();
Console.WriteLine("To: ");
var to = Console.ReadLine();

var validateRange = new ValidatorNumberType(from, to);

validateRange.Validate();


