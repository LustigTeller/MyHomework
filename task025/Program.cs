// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень


Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B, обозначающее степень, в которую будет возводиться число: ");
int b = Convert.ToInt32(Console.ReadLine());
int num = 1;
for (int i = 0; i < b; i++)
    num = num * a;
Console.WriteLine($"{a} в {b} степени = {num}");
// int i = 0;
// while (i < b)
// {
//     num = num * a;
//     i++;
// }
// Console.WriteLine($"{a} в {b} степени = {num}");