

using ChallengeApp;
using System;


Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Podaj ocenę pracownika: ");

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var ststistics = employee.GetStatistics();
Console.WriteLine($"Average: {ststistics.Average}");
Console.WriteLine($"Min: {ststistics.Min}");
Console.WriteLine($"Max: {ststistics.Max}");