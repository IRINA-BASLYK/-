/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int i = 1000;
int x = 1;

if (num < 100)
{
    Console.WriteLine(num + "-> третьей цифры нет");
}

else
{
while (num > i)
{
    i = i * 10;
    x = x * 10;
}
Console.WriteLine((num / x) % 10 + "-> третья цифра числа");
}






