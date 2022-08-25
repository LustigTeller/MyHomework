// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.Write("Введите количество строк: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[numberA, numberB];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

double[] res = new double[matrix.GetLength(1)];
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = sum + matrix[i, j];

    }
    res[j] = sum / matrix.GetLength(1);
    Console.Write($"{res[j]} ");
}

