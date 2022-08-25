//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int numberA = new Random().Next(100, 999);

Console.WriteLine($"Three-digit number: {numberA}");

Console.WriteLine($"Second digit: {numberA / 10 % 10}");