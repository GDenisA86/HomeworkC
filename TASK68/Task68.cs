﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Aker(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Aker(m - 1, 1);
  else return Aker(m - 1, Aker(m, n - 1));
}

Console.Write("Введите первое число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите последнее число N: ");
int n = int.Parse(Console.ReadLine()!);
int Akerman = Aker(m, n);
Console.Write($"Функция Аккермана = {Akerman} ");