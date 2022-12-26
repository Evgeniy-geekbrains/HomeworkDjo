// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

using static System.Console;

WriteLine("Введите число: ");
int n = int.Parse(ReadLine()!);
for (int i = 1; i <= n; i++)
if (i%2 == 0)
WriteLine(i);