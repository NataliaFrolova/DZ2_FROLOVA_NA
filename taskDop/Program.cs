//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write((number % 7 == 0) && (number % 23 == 0) ? "кратно" : "не кратно");
