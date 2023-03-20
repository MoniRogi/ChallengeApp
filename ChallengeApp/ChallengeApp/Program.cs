// Zadanie domowe nr 6

using ChallengeApp;

Employee employee1 = new Employee("Monika", "Rogalska",16);
Employee employee2 = new Employee("Anna", "Owczarek", 24);
Employee employee3 = new Employee("Oskar","Kowalski",35);

employee1.AddScore(3);
employee1.AddScore(4);
employee1.AddScore(1);
employee1.AddScore(7);
employee1.AddScore(10);

employee2.AddScore(5);
employee2.AddScore(1);
employee2.AddScore(8);
employee2.AddScore(4);
employee2.AddScore(6);

employee3.AddScore(0);
employee3.AddScore(9);
employee3.AddScore(2);
employee3.AddScore(1);
employee3.AddScore(8);


List<Employee> employees = new List<Employee>()
{ employee1, employee2, employee3 };

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var Employee in employees)
{
    if (Employee.Result > maxResult)
    {

        employeeWithMaxResult = Employee;
        maxResult = Employee.Result;
    }
}


Console.WriteLine("Najlepszy pracownik miesiąca: ");
Console.WriteLine("Imię => " + employeeWithMaxResult.Name + "; Nazwisko => " + employeeWithMaxResult.Surname + "; Wiek => " + employeeWithMaxResult.Age + "; Maxymalna liczba punktów: " + maxResult );
Console.WriteLine("Gratulujemy!");
