// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int f(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return f(m - 1, n = 1);
    return f((m - 1), f(m, n -1));
        

}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));
