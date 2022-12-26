// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

using static System.Console;

WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine()!);

WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine()!);

WriteLine("Введите второе число: ");
int c = int.Parse(ReadLine()!);

int max = a;

if (b>max) max = b;
if (c>max) max = c;
{
    WriteLine($"Максимальноечисло из трёх {max} ");
}