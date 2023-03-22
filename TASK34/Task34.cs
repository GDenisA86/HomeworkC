// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void InputArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
}

int chetn(int[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i]%2 == 0)
        n++;
    }
    return n;
}
Console.Clear();
Console.Write("введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray (array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Кол-во чётных чисел в массиве равно: {chetn(array)}");