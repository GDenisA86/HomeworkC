// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Vvod(string message);
{
    System.Console.Write(message);
    string value = Console.Write(message);
    int result = Convert.ToInt32(value);
    return result;
}

int[] InputArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Vvod($"Введите {i + 1}-й элемент");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {arra[i]}");
    }
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]>0) count++;
    }
    return count;
}

int lentght = Vvod("Введите кол-во элементов >");
int[] array;
array = InputArray(lentght);
PrintArray(array);
Console.WriteLine($"Кол-во чисел больше 0 - {Count(array)}");