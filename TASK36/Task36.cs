// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void InputArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);
}

int schet(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        sum=sum+array[i];
    }
    return sum;
}
Console.Clear();
Console.Write("введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray (array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {schet(array)}");