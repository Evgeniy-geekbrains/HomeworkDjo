// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

using static System.Console;

WriteLine("Введите трёхзначое число: ");
int number = int.Parse(ReadLine()!);

WriteLine ($"Вторая цифра в числе: {number/10%10}");