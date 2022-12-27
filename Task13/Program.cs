// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.

using static System.Console;

WriteLine("Введите число: ");

int number = Convert.ToInt32(ReadLine()!);

string numberPos = Convert.ToString(number);

if (numberPos.Length >2)
{
    WriteLine("Третья цифра: " + numberPos[2]);
}
else
{
    WriteLine("Третьей цифры нет!");
}