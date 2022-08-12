// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int ost = 0;
while (num != 0)
{
    ost = num % 10;
    num = num / 10;
    sum = sum + ost;
}
Console.WriteLine($"Сумма цифр в числе = {sum}");