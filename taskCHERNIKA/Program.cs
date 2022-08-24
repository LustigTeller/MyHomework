// В фермерском хозяйстве в Карелии выращивают чернику. Она растет на круглой грядке, причем кусты высажены только по окружности. 
// Таким образом, у каждого куста есть ровно два соседних. 
// Всего на грядке растет N кустов.

// Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное число ягод – на i-ом кусте выросло ai ягод.

// В этом фермерском хозяйстве внедрена система автоматического сбора черники. 
// Эта система состоит из управляющего модуля и нескольких собирающих модулей. 
// Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, собирает ягоды с этого куста и с двух соседних с ним.

// Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль, 
// находясь перед некоторым кустом заданной во входном файле грядки.



Console.Write("Введите количество кустов: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
for (int i = 0; i < number; i++)
{
    Console.Write("Введите количество ягод на кустах: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int[] arraySum = new int[number];
for (int i = 1; i < number - 1; i++)
    arraySum[i - 1] = array[i - 1] + array[i] + array[i + 1];

arraySum[number - 2] = array[0] + array[number - 1] + array[number - 2];
arraySum[number - 1] = array[number - 1] + array[0] + array[1];

int maxNumber = arraySum[0];
for (int i = 0; i < number; i++)
{
    if (maxNumber < arraySum[i])
        maxNumber = arraySum[i];
}

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("[" + string.Join(", ", arraySum) + "]");
Console.WriteLine(maxNumber);