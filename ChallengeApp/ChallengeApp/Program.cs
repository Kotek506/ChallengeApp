using ChallengeApp;

var employee = new Employee("Patryk", "Piskorz");
employee.AddGrade('9');
employee.AddGrade("czesc");
employee.AddGrade("20000");
employee.AddGrade("3");
employee.AddGrade(6);
employee.AddGrade(7);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");



