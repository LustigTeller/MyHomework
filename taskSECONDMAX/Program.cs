// Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, то есть элемента, 
// который будет наибольшим, если из последовательности удалить наибольший элемент.

Console.Write($"Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 99)
{
    Console.Write("Ошибка! Введи число меньше 100: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int max = 0;
int secondmax = 1;
while (n != 0)
{
    if (n > max)
    {
        secondmax = max;
        max = n;
    }
    else
    {
        if (n > secondmax)
            secondmax = n;
    }
    Console.Write($"Введите число: ");
    n = Convert.ToInt32(Console.ReadLine());
    while (n > 99)
    {
        Console.Write("Ошибка! Введи число меньше 100: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine(secondmax);