// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.



int numberA = new Random().Next(1, 15);
int numberB = new Random().Next(1, 15);
Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
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
if (row <= numberA && column <= numberB)
    Console.WriteLine($"Найденный элемент: {matrix[row - 1, column - 1]}");
else
    Console.WriteLine("Данного элемента нет");
