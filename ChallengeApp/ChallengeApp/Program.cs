using ChallengeApp;

Employee employee = new Employee("Adam", "Kowalski");

employee.AddGrade("1");
employee.AddGrade(2);
employee.AddGrade(12.3);
employee.AddGrade(46L);
employee.AddGrade(64d);
employee.AddGrade(80m);
employee.AddGrade(3.41E+40);
employee.AddGrade(90);

var stats1 = employee.GetStatisticsWithFor();
var stats2 = employee.GetStatisticsWithFor();
var stats3 = employee.GetStatisticsWithDoWhile();
var stats4 = employee.GetStatisticsWithWhile();

Statistics[] stats = {stats1, stats2, stats3, stats4};

foreach(Statistics stat in stats)
{ 
Console.WriteLine($"Average: {stat.Average:N2}");
Console.WriteLine($"Max: {stat.Max}");
Console.WriteLine($"Min: {stat.Min}");
}