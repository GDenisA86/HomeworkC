Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000|| n > 99999)
{
Console.WriteLine("Вы ошиблись это не пятизначное число, введите снова");
n = Convert.ToInt32(Console.ReadLine());
}
int a = n/10000;
int b = (n%10000)/1000;
int c = (n%100)/10;
int d = n%10;
if (a==d||c==d)
    Console.Write("Число является полиномом");
else
    Console.Write("Число не является полиномом");
