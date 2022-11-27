Console.Clear();
double a = Convert.ToInt32(Console.ReadLine());
double b = Convert.ToInt32 (Console.ReadLine());

double sqeare =  b * b;
if (a == sqeare)
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($"Число {a} не является квадратом числа {b}");
}
