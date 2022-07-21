// Вклад в банке составляет X рублей. Ежегодно он увеличивается на P процентов, после чего дробная часть копеек отбрасывается.
// Требуется определить: через сколько лет вклад составит не менее Y рублей.
// Входной файл INPUT.TXT содержит три натуральных числа: X, P и Y (X,Y ≤ 1000, P ≤ 100).  
// В выходной файл OUTPUT.TXT выведите целое число – ответ на задачу.

Console.Write("Вклад = ");
int x = Convert.ToInt32(Console.ReadLine());
while (x <= 0 || x > 1000)
{
    Console.Write("Ошибка! Введите число <= 1000: ");
    x = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Процент = ");
int p = Convert.ToInt32(Console.ReadLine());
while (p <= 0 || p > 100)
{
    Console.Write("Ошибка! Введите число <= 100: ");
    p = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Доход = ");
int y = Convert.ToInt32(Console.ReadLine());
while (y <= 0 || y > 1000)
{
    Console.Write("Ошибка! Введите число <= 1000: ");
    y = Convert.ToInt32(Console.ReadLine());
}
int v = 0;
while (x <= y)
{
    x = x + (x * p / 100);
    v++;
}
Console.WriteLine(v);
