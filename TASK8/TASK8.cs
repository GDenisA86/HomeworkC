﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.Write("Пожалуйста, введите чило: ");
int a = int.Parse(Console.ReadLine()!);
int i = 0;
while (i < a-1)
{i+=2;
Console.Write($"{i} ");
}