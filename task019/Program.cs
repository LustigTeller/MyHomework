// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 10000 || num > 99999)
{
    Console.Write("Ошибка! Введите пятизначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}
int num1 = num / 10000;
int num2 = num / 1000 % 10;
int num3 = num / 10 % 10;
int num4 = num % 10;
if (num1 == num4 && num2 == num3)
    Console.WriteLine($"Число {num} - палиндром!");
else
    Console.WriteLine($"Число {num} - не является палиндромом!");

