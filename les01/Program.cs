int a, b;

Console.WriteLine ("Введите числа: ");

a = Convert.ToInt32(Console.ReadLine());

b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"max  {a}");
    Console.WriteLine($"min  {b}");
}
else 
{
    Console.WriteLine($"max  {b}");
    Console.WriteLine($"min  {a}");
}