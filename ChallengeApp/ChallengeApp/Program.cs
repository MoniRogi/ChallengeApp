using ChallengeApp;



Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Podaj dane pracownika: ");
Console.WriteLine("Wpisz imię: ");
var name = Console.ReadLine();
Console.WriteLine("Wpisz nazwisko: ");
var surname = Console.ReadLine();
Console.WriteLine("Wpisz płeć (K/M): ");
var sex = Console.ReadLine();

var employee = new Employee(name, surname, sex);

Console.WriteLine("Podaj ocenę pracownika: ");
var input = Console.ReadLine();

try
{
    employee.AddGrade(input);
}
catch (Exception e)
{
    Console.WriteLine($"Exception catched: {e.Message}");
}

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika (jeśli chcesz wyjść naciśnij 'q'): ");
    input = Console.ReadLine();
    if (input == "q")
    {
        Console.WriteLine("Oto wyniki podanego pracownika: "); 
        break;        
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
  
}

var ststistics = employee.GetStatistics();
Console.WriteLine($"Average: {ststistics.Average}");
Console.WriteLine($"Min: {ststistics.Min}");
Console.WriteLine($"Max: {ststistics.Max}");
Console.WriteLine($"AverageLetter: {ststistics.AverageLetter}");