﻿using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny pracownika");
Console.WriteLine("==========================================");
Console.WriteLine();

EmployeeInFile employee = new EmployeeInFile("Adam", "Nowak");

Console.WriteLine(employee.Name);  
Console.WriteLine(employee.Surname);

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
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine("==========================================");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
