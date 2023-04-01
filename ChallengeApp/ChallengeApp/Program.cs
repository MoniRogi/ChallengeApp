

using ChallengeApp;

var employee = new Employee("Monika", "Boratyn");
employee.AddGrade(3);
employee.AddGrade(6);
employee.AddGrade(10);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
