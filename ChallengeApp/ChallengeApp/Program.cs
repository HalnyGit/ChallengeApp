using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny pracownika");
Console.WriteLine("==========================================");
Console.WriteLine();

Supervisor supervisor = new Supervisor("Adam", "Nowak");

Console.WriteLine(supervisor.Name);  
Console.WriteLine(supervisor.Surname);

while (true)
{
    Console.WriteLine("""Podaj kolejną ocenę pracownika lub "q" - żeby wyjść z modułu wprowadzania ocen i przejść do podsumowania""");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

var statistics = supervisor.GetStatistics();
Console.WriteLine("==========================================");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
