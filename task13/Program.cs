//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Ведите число");
string numberA = Console.ReadLine();

int numberB = Convert.ToInt32(numberA);

numberA.Length.ToString();

if (numberB >= 100) Console.WriteLine("Третья цифра: " + numberA[2]);
else Console.WriteLine("третьей цифры нет");
