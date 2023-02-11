using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do 0ceny pracownika");
Console.WriteLine("==========================================");
Console.WriteLine();

Employee employee = new Employee();

while(true)
{
    Console.WriteLine("""Podaj kolejną ocenę pracownika lub "q" - żeby wyjść z modułu wprowadzania ocen i przejść do podsumowania""");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine("==========================================");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

