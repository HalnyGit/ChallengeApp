using ChallengeApp;

Employee employee = new Employee("Adam", "Kowalski");

employee.AddGrade("1");
employee.AddGrade(2);
employee.AddGrade(12.3);
employee.AddGrade(46L);
employee.AddGrade(64d);
employee.AddGrade(80m);
employee.AddGrade(3.41E+40);

var stats = employee.GetStatistics();

Console.WriteLine($"Average: {stats.Average:N2}");
Console.WriteLine($"Max: {stats.Max}");
Console.WriteLine($"Min: {stats.Min}");