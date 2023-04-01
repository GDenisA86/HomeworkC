// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции нет

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void Poisk(int[,] matrix)
{
Console.WriteLine("Введите индекс строки: ");
int r = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите индекс столбца: ");
int c = int.Parse(Console.ReadLine()!);
    while (r>matrix.GetLength(0)&&c>matrix.GetLength(1))
    {
    Console.WriteLine("Нет такой позиции");
    Console.WriteLine("Введите индекс строки: ");
    r = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите индекс строки: ");
    c = int.Parse(Console.ReadLine()!);
    }
Console.WriteLine($"Найденное число: {matrix[r, c]}");
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Poisk(matrix);

