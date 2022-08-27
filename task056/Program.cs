// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.



Console.Write("Введите количество строк матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b || a < b)
{
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
    int index = 0;
    int sum = 0;
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            sum = sum + matrix[i, j];
        if (i == 0) result = sum;
        else if (sum < result)
        {
            result = sum;
            index = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в {index + 1} строке");
}
else
    Console.WriteLine("Не прямоугольный массив");