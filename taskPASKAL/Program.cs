﻿//Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника



int Factorial(int n)
{
    int i, x = 1;
    for (i = 1; i <= n; i++)
        x *= i;
    return x;
}


Console.Write("Введите число элементов в основании треугольника Паскаля: ");
int n = Convert.ToInt32(Console.ReadLine());
int i, c;

for (i = 0; i < n; i++)
{
    for (c = 0; c <= (n - i); c++)
        Console.Write(" ");

    for (c = 0; c <= i; c++)
    {
        Console.Write(" ");
        Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c)));
    }
    Console.WriteLine();
    Console.WriteLine();
}