//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 6 (в задаче ошибка, здесь написано было 5)
//78 -> третьей цифры нет
//32679 -> 6

int value = int.Parse(Console.ReadLine());

if ((value >= 100) || (value <= -100))
{
    int result = (value/100)%10;
    if (result < 0)
    {
        result = result*(-1);
    }
    Console.WriteLine(result);
}
else

Console.WriteLine("А третьей-то цифры тут и нет!");
