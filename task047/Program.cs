// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.Write("Введите количество строк: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int numberB = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[numberA, numberB];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().NextDouble();
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}