// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
while (a == b)
{
    Console.WriteLine("Числа одинаковые. Повторите попытку");
    Console.Write("Введите первое число: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    b = Convert.ToInt32(Console.ReadLine());
}
if (a > b)
    Console.WriteLine($"Число {a} больше числа {b}");
else
    Console.WriteLine($"Число {b} больше числа {a}");