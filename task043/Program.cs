// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.Write("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

/*
k1 * x + b1 = k2 * x + b2
k1 * x - k2 * x = b2 - b1
x = (b2 - b1) / (k1 - k2)
*/

double b = (b2 - b1);
double k = (k1 - k2);
double numX = b / k;
double numY = k1 * numX + b1;
Console.WriteLine($"Точка пересечения двух прямых ({numX}, {numY})");
