// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным.

using static System.Console;

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);

if (a%2 == 0)
{
    WriteLine("Число является чётным!");
}
else
{
    WriteLine("Число не является чётным!");
}