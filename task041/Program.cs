// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество элементов: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < num; i++)
{
    Console.Write("Введите элемент: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count++;
}
Console.WriteLine($"Количество положительных введенных чисел: {count}");
