using ChallengeApp;

Employee employee = new Employee("Adam", "Kowalski");

employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);

var stats = employee.GetStatistics();

Console.WriteLine($"Average: {stats.Average:N2}");
Console.WriteLine($"Max: {stats.Max}");
Console.WriteLine($"Min: {stats.Min}");