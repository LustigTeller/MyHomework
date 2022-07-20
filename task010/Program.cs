// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


// int num = new Random().Next(100,1000);
// Console.WriteLine(num);
// int a = num / 10 % 10;
// Console.WriteLine(a);

// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num >= 100 && num <= 999)
//     Console.WriteLine(num / 10 % 10);
// else
// {
//     while (num <= 100 || num >= 999)
//     {
//         Console.WriteLine("Ошибка! Введите трехзначное число: ");
//         num = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.WriteLine(num / 10 % 10);
// }

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num <= 100 || num >= 999)
{
    Console.WriteLine("Ошибка! Введите трехзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(num / 10 % 10);