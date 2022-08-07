// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите первое число: ");
  int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine ());
for (int i = n; i <= m; i++)
{
if (i % 2 == 0) 
    {
    Console.Write(i + " ");
    }
}
        Console.WriteLine();
