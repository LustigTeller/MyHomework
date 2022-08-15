// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


Console.WriteLine("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int col = 0;
for (int i = 0; i < num; i++)
{
    array[i] = new Random().Next(100,1000);
    if (array[i] % 2 == 0) col++;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine(col);