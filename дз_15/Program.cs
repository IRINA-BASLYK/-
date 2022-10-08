/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */


Console.WriteLine("Введите число от 1 до 7");
int num = int.Parse(Console.ReadLine());

int a = 1;
int b = 2;
int c = 3;
int d = 4;
int i = 5;
int f = 6;
int g = 7;

while (num < 1 || num >= 8)
{
    Console.WriteLine("Введите число от 1 до 7");
    num = int.Parse(Console.ReadLine());
}


if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5)
{
    Console.WriteLine("Рабочий день");
}

else
{
     Console.WriteLine("ВЫХОДНОЙ");
}


