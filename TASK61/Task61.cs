// Задача 61(Дополнительная задача):Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
// Console.WriteLine("Введите количество строк треугольника Паскаля:");


void PrintTriangle(int n)
{
    int[,] matrix = new int[n, n];
    for (int line = 0; line < n; line++)
    {
        for (int i = 0; i <= line; i++)
        {
         if (line == i || i == 0)
         matrix[line, i] = 1;
         else
        matrix[line, i] = matrix[line - 1, i - 1] + matrix[line - 1, i];
        Console.Write($"{matrix[line, i]} \t");
        }
        Console.WriteLine("");
    }
}

Console.WriteLine("Введите первые N строк треугольника Паскаля: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Треугольник Паскаля:");
PrintTriangle(n);
