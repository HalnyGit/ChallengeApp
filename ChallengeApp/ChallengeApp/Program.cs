int number = 1568578985;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();

int[] memo = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

foreach(var elem in letters)
{
     memo[(int)char.GetNumericValue(elem)]++;
}

for (int i = 0; i < memo.Length; i++)
{ 
    Console.WriteLine(i + "=>" + memo[i]);
}