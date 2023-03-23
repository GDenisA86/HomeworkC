// Задача 38: Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3,01 7,23 22,79 2,38 78,45] -> 76,07
void InputArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (30 - 10) + 10, 2);
}

double max (double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max<array[i])
        max=array[i];
    }
    return max;
}

double min (double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min>array[i])
        min=array[i];
    }
    return min;
}

Console.Clear();
Console.Write("введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine()!);
double[] array = new double[n];
InputArray (array);
Console.WriteLine($"Начальный массив: [{string.Join(",  ", array)}]");
Console.WriteLine($"Максимальное число в масиве: {max(array)}");
Console.WriteLine($"Минимальное число в масиве: {min(array)}");
Console.WriteLine($"Разница между максимальным и минимальным значениями массива равно: {max(array)-min(array)}");
