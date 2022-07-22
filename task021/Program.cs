// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


Console.Write("Введите значение X первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение X второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + (Math.Pow((z2 - z1), 2))));
Console.WriteLine(string.Format("{0:F3}", distance));