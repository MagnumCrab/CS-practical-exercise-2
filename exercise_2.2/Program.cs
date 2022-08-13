// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number, number2;

Console.Write("Введите любое число: ");

number = Convert.ToInt32(Console.ReadLine());

string number3 = Convert.ToString(number);

number2 = number3.Length;

if (number2 > 2)
{
    Console.WriteLine("Третья цифра заданного числа: " + number3[2]);
}
else Console.WriteLine("третьей цифры нет");