// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите, пожалуйста, цифру, обозначающую день недели (от 1 до 7), а я подскажу, выходной ли это");
string day = Console.ReadLine();

if (
    (day.ToLower() == "6") ||
    (day.ToLower() == "7")
    )
{
    Console.WriteLine("ДА!!!");
}
else
{
    Console.WriteLine("Нет");
}

