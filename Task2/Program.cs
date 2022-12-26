// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
using static System.Console;

WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine()!);

WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine()!);

if (a>b)
{
    WriteLine("Первое число больше второго!");    
}
else
{
    WriteLine("Второе число больше первого!");
}