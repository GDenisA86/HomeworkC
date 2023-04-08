﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sum(int m, int n)
{
if (m==n)
return n;
else return m + sum(m + 1, n);
}

Console.Clear();
Console.Write("Введите первое число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите последнее число N: ");
int n = int.Parse(Console.ReadLine()!);
sum(m,n);
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {sum(m,n)}");