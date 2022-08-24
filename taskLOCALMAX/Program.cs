// Элемент последовательности называется локальным максимумом, если он строго больше предыдущего и последующего элемента последовательности.
// Первый и последний элемент последовательности не являются локальными максимумами.
// Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется определить наименьшее расстояние между двумя локальными максимумами последовательности натуральных чисел, завершающейся числом 0.
// Выведите целое число – наименьшее расстояние между двумя локальными максимумами.
// Если в последовательности нет двух локальных максимумов, выведите число 0.

int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[101];
int i = 0;
while (n != 0)
{
    array[i] = n;
    n = Convert.ToInt32(Console.ReadLine());
    i++;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");

int[] dlina = new int[i];
int k = 0;
for (int j = 1; j < i - 1; j++)
{
    if (array[j] > array[j - 1] && array[j] > array[j + 1])
    {
        dlina[k] = j;
        k++;
    }
}
Console.WriteLine("[" + string.Join(", ", dlina) + "]");

int[] difference = new int[k * k];
int c = 0;
for (int j = 0; j < k; j++)
{
    for (int m = j + 1; m < k; m++)
    {
        difference[c] = Math.Abs(dlina[j] - dlina[m]);
        c++;
    }
}
Console.WriteLine("[" + string.Join(", ", difference) + "]");

int mins = difference[0];
for (int j = 0; j < difference.Length; j++)
{
    if (difference[j] != 0 && difference[j] < mins)
        mins = difference[j];
}
Console.WriteLine(mins);



/*
Console.Write("Введите количество чисел в последовательности: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
int localMax = 0;
int localMax2 = 0;
for (int i = 0; i < a; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write($"{array[i]} ");
}
for (int i = 0; i < a; i++)
{
    if (array[i] > localMax) localMax = array[i];
    else
    {
       if  (array[i] > localMax2) localMax2 = array[i];
    }
}
Console.WriteLine();
Console.WriteLine(localMax);
Console.WriteLine(localMax2);
*/


















// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// int localMax1 = 0;
// int dist = 0;
// if (numA > num && numA > numB) numA = localMax1;
// else
// {

//     Console.Write("Введите число: ");
//     num = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число: ");
//     numA = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число: ");
//     numB = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine(localMax1);



// while (num != 0 && numA != 0 && numB != 0)
// {
//     if (numA > num && numA > numB) numA = localMax1;
//     else
//     {
//         while (numA > num && numA > numB)
//         {
//             Console.Write("Введите число: ");
//             num = Convert.ToInt32(Console.ReadLine());
//             Console.Write("Введите число: ");
//             numA = Convert.ToInt32(Console.ReadLine());
//             Console.Write("Введите число: ");
//             numB = Convert.ToInt32(Console.ReadLine());
//         }
//     }

// }