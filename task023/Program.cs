// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
double result;
while (count <= num)
{
    result = Math.Pow(count, 3);
    Console.Write($"{result} ");
    count++;
}
