using ChallengeApp;

var employee = new Employee("Patryk", "Piskorz");
employee.AddGrade('9');
employee.AddGrade("7");
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine("Get Statistics With ForEach");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");



