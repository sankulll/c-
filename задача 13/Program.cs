// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);
if (n < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (n > 999)
    {
        n /= 10;
    }
    Console.WriteLine(n % 10);
}
