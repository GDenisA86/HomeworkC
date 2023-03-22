// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void InputArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
}

int schet(int[] array)
{
    int n = array[1];
    for (int i = 0; i < array.Length; i=i+2)
    {
        n=n+array[i];
    }
    return n;
}
Console.Clear();
Console.Write("введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray (array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Кол-во чётных чисел в массиве равно: {schet(array)}");