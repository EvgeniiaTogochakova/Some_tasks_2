// 21. Программа проверяет пятизначное число на палиндром

Console.WriteLine("Введите, пожалуйста, пятизначное число, а я подскажу, палиндром ли это");
int value = int.Parse(Console.ReadLine());
int e = value % 10;
int d = (value % 100)/ 10;
int a = value / 10000;
int b = (value / 1000) % 10;

if ((a == e) && (b == d))
{
    Console.WriteLine("Да, это палиндром");
}
else
{
    Console.WriteLine("Нет, это не палиндром");
}
