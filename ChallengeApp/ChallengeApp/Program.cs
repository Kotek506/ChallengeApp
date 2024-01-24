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

var statistics1 = employee.GetStatisticsWithDoWhile();
Console.WriteLine("Get Statistics With Do While");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

var statistics2 = employee.GetStatisticsWithWhile();
Console.WriteLine("Get Statistics With While");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

var statistics3 = employee.GetStatisticsWithFor();
Console.WriteLine("Get Statistics With For");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");



