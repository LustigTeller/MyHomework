// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



Console.Write("Введите количество строк матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrixOne = new int[a, b];
for (int i = 0; i < matrixOne.GetLength(0); i++)
{
    for (int j = 0; j < matrixOne.GetLength(1); j++)
    {
        matrixOne[i, j] = new Random().Next(1, 11);
        Console.Write(matrixOne[i, j] + " \t");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] matrixTwo = new int[a, b];
for (int i = 0; i < matrixTwo.GetLength(0); i++)
{
    for (int j = 0; j < matrixTwo.GetLength(1); j++)
    {
        matrixTwo[i, j] = new Random().Next(1, 11);
        Console.Write(matrixTwo[i, j] + " \t");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] matrixThree = new int[a, b];
for (int i = 0; i < matrixThree.GetLength(0); i++)
{
    for (int j = 0; j < matrixThree.GetLength(1); j++)
    {
        matrixThree[i, j] = matrixOne[i, j] * matrixTwo[i, j];
        Console.Write(matrixThree[i, j] + " \t");
    }
    Console.WriteLine();
}