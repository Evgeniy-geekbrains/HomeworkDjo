// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день
// выходным.

using static System.Console;

WriteLine("Введите номер дня недели: ");
int number = int.Parse(ReadLine()!);

if (number == 6 || number == 7)
{
    WriteLine("ДА!");
}
else if (number < 1 || number > 7)
WriteLine("Ошибка! Введите номер дня от 1 до 7");

else
WriteLine("НЕТ!");