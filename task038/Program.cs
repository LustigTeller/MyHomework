// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.



Console.WriteLine("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];
for (int i = 0; i < num; i++)
{
    Console.WriteLine("Введите элемент массива: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}

double max = array[0];
double min = array[0];
double diff = 0;
for (int i = 0; i < num; i++)
{
    if (array[i] > max) max = array[i];
    else
    {
        if (array[i] < min) min = array[i];
    }
}
Console.WriteLine(max);
Console.WriteLine(min);
diff = max - min;
Console.WriteLine("[" + string.Join("; ", array) + "]");
Console.WriteLine(diff);