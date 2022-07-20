// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Write("Введите цифру: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 1 || num > 7)
{
    Console.Write("Цифра не соответствует дню недели! Введите цифру: ");
    num = Convert.ToInt32(Console.ReadLine());
}
if (num > 5)
{
    if (num == 6)
        Console.WriteLine($"{num} - Суббота (выходной)");
    else
        Console.WriteLine($"{num} - Воскресенье (выходной)");
}
else
{
    if (num == 1)
        Console.WriteLine($"{num} - Понедельник (будний день)");
    if (num == 2)
        Console.WriteLine($"{num} - Вторник (будний день)");
    if (num == 3)
        Console.WriteLine($"{num} - Среда (будний день)");
    if (num == 4)
        Console.WriteLine($"{num} - Четверг (будний день)");
    if (num == 5)
        Console.WriteLine($"{num} - Пятница (будний день)");
}


// int num = new Random().Next(1, 8);
// if (num == 1)
//     Console.WriteLine($"{num} - Понедельник (будний день)");
// if (num == 2)
//     Console.WriteLine($"{num} - Вторник (будний день)");
// if (num == 3)
//     Console.WriteLine($"{num} - Среда (будний день)");
// if (num == 4)
//     Console.WriteLine($"{num} - Четверг (будний день)");
// if (num == 5)
//     Console.WriteLine($"{num} - Пятница (будний день)");
// if (num == 6)
//     Console.WriteLine($"{num} - Суббота (выходной)");
// if (num == 7)
//     Console.WriteLine($"{num} - Воскресенье (выходной)");