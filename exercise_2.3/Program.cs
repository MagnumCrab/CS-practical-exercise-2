// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int number;

Console.Write("Введите цифру, обозначающую день недели (от 1 до 7):");

number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    if (number == 6 | number == 7) Console.WriteLine("Это выходной");
    else Console.WriteLine("Это не выходной");
}
else Console.WriteLine("Неверная цифра");