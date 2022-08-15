// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


Console.WriteLine("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int sum = 0;
for (int i = 0; i < num; i++)
{
    array[i] = new Random().Next(1,25);
    if (i % 2 > 0) sum = array[i] + sum;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine(sum);