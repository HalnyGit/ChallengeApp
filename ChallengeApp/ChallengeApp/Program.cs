string name = "Ewa";
bool isMan = false;
int age = 44;

if (isMan == true && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (isMan == false && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else
{
    Console.WriteLine("Nie spełnia żadnych wymaganych kryteriów");
}





