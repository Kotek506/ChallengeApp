using ChallengeApp;

//var employee = new Employee("Patryk", "Piskorz");
//employee.AddGrade('9');
//employee.AddGrade("7");
//employee.AddGrade(60);
//employee.AddGrade('a');
//var statistics = employee.GetStatistics();
//Console.WriteLine($"Average: {statistics.Average:N2}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");
//Console.WriteLine($"Letter: {statistics.AverageLetter}");


Console.WriteLine("Witamy w programie");
Console.WriteLine("=======================");
Console.WriteLine();


var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"MIN: {statistics.Min}");
Console.WriteLine($"MAX: {statistics.Max}");
Console.WriteLine($"Letter: {statistics.AverageLetter}");


//var employee = new Employee();
//employee.AddGrade(input);




