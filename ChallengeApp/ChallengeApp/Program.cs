using ChallengeApp;



Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Podaj dane pracownika: ");
//Console.WriteLine("Wpisz imię: ");
//var name = Console.ReadLine();
//Console.WriteLine("Wpisz nazwisko: ");
//var surname = Console.ReadLine();
//Console.WriteLine("Wpisz płeć (K/M): ");
//var sex = Console.ReadLine();

var employee = new EmployeeInMemory("Monika", "hhg", "k");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nnową ocenę");
}

employee.GradeAdded -= EmployeeGradeAdded;

employee.AddGrade(0.6f);

//Console.WriteLine();
//var statisticsEmployeeInFile = employee.GetStatistics();
//Console.WriteLine($"Average: {statisticsEmployeeInFile.Average}");
//Console.WriteLine($"Min: {statisticsEmployeeInFile.Min}");
//Console.WriteLine($"Max: {statisticsEmployeeInFile.Max}");
//Console.WriteLine($"AverageLetter: {statisticsEmployeeInFile.AverageLetter}");

//Console.WriteLine("Podaj ocenę pracownika: ");
//var input = Console.ReadLine();

//try
//{
//    employee.AddGrade(input);
//}
//catch (Exception e)
//{
//    Console.WriteLine($"Exception catched: {e.Message}");
//}

while (true)
{
    Console.WriteLine("podaj kolejną ocenę pracownika (jeśli chcesz wyjść naciśnij 'q'): ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        Console.WriteLine("oto wyniki podanego pracownika: ");
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
Console.WriteLine($"average: {ststistics.Average}");
Console.WriteLine($"min: {ststistics.Min}");
Console.WriteLine($"max: {ststistics.Max}");
Console.WriteLine($"averageletter: {ststistics.AverageLetter}");