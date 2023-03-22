// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.Write("Введите число A: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B: ");
double b = Convert.ToDouble(Console.ReadLine());
double step = a;
while (b<=0)
{
    Console.WriteLine("Неверное значение, введите число больше 0: ");
    b = Convert.ToDouble(Console.ReadLine());
}
for (int i = 0; i<(b-1);i++)
{
    step = step*a;
}
Console.Write(step);