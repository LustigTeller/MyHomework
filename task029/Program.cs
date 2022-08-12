// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.Write("Введите элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
