using ChallengeApp;



Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Podaj dane pracownika: ");
Console.WriteLine("Wpisz imię: ");
var name = Console.ReadLine();
Console.WriteLine("Wpisz nazwisko ");
var surname = Console.ReadLine();

var employee = new Employee(name, surname);
Console.WriteLine("Podaj ocenę pracownika: ");

var input = Console.ReadLine();
employee.AddGrade(input);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika (jeśli chcesz wyjść naciśnij 'q'): ");
    input = Console.ReadLine();
    if (input == "q")
    {
        Console.WriteLine("Oto wyniki podanego pracownika: "); 
        break;        
    }
    employee.AddGrade(input);
}

var ststistics = employee.GetStatistics();
Console.WriteLine($"Average: {ststistics.Average}");
Console.WriteLine($"Min: {ststistics.Min}");
Console.WriteLine($"Max: {ststistics.Max}");