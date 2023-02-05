using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kowalski");
Employee employee2 = new Employee("Ewa", "Nowak");
Employee employee3 = new Employee("Michał", "Wiśniewski");

employee1.AddScore(1);
employee1.AddScore(4);
employee1.AddScore(7);
employee1.AddScore(7);
employee1.AddScore(9);

employee2.AddScore(6);
employee2.AddScore(8);
employee2.AddScore(9);
employee2.AddScore(6);
employee2.AddScore(5);

employee3.AddScore(6);
employee3.AddScore(8);
employee3.AddScore(9);
employee3.AddScore(6);
employee3.AddScore(5);

List<Employee> employees = new List<Employee>();
employees.Add(employee1);
employees.Add(employee2); 
employees.Add(employee3);

List<int> bestResults = new List<int>();

foreach (Employee employee in employees)
{
    bestResults.Add(employee.Result);
}

int bestResult = bestResults.Max();

List<Employee> topEmployee = new List<Employee>();

foreach (Employee employee in employees)
{
    if (employee.Result == bestResult)
    {
        topEmployee.Add(employee);
    }
}

Console.WriteLine("Pracownik/pracownicy z najwyższymi wynikami:");
foreach (Employee employee in topEmployee)
{
    Console.WriteLine(employee.Name + " " + employee.Surname + " " + employee.Result);
}