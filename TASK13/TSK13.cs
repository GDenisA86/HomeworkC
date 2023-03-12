// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a<100)
{
    Console.WriteLine("третьей цифры нет: ");
    a = Convert.ToInt32(Console.ReadLine());
}
else
while (a>999)
{
    a/=10;
}
int c = a%10;
Console.WriteLine(c);