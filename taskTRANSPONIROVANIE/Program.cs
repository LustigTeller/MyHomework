// Первая строка входного файла INPUT.TXT содержит натуральное число N – количество строк и столбцов матрицы.
// В каждой из последующих N строк записаны N целых чисел – элементы матрицы. 
// Все числа во входных данных не превышают 100 по абсолютной величине.


Console.Write("Введите число N - количество строк и столбцов матрицы: ");
int num = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[num, num];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 11);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i > j)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write(matrix[i, j] + "\t");
    Console.WriteLine();
}
