/* // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
while (num < 100 || num > 1000)
{
    Console.WriteLine("Введите трехзначное число");
    num = int.Parse(Console.ReadLine());
}

int x = num % 10;
int result = (num - x) % 100 / 10;
Console.WriteLine("вторая цифра этого числа -> " + result);


