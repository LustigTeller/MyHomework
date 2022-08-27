// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


Console.Write("Введите количество строк матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[a, b];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 11);
        Console.Write(matrix[i, j] + " \t");
    }
    Console.WriteLine();
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int maxPosition = j;
        for (int k = j + 1; k < matrix.GetLength(1); k++)
            if (matrix[i, k] > matrix[i, maxPosition]) maxPosition = k;
        int temp = matrix[i, j];
        matrix[i, j] = matrix[i, maxPosition];
        matrix[i, maxPosition] = temp;
    }
}
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write(matrix[i, j] + " \t");
    Console.WriteLine();
}