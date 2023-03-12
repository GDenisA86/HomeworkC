// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите день недели (цифру): ");
int a = Convert.ToInt32(Console.ReadLine());
while (a<1 || a>7)
{
    Console.WriteLine("Такого номера недели не существует, введите повторно: ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a<6) Console.WriteLine("Будний день");
else
Console.WriteLine("Выходной");
