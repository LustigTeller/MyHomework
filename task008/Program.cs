// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int a = new Random().Next(1, 99);
Console.WriteLine(a);
int i = 1;
while (i <= a)
{
    if (i % 2 == 0)
        Console.Write(i);
    Console.Write(" ");
    i++;
}