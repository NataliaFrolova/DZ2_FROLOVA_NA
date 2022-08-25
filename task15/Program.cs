//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 5 && number < 8) Console.Write("Выходной день: ");
else if (number > 0 && number < 6) Console.Write("Рабочий день: ");
else System.Console.WriteLine("Bad number");


if (number >= 1 && number <= 7)
{
    switch (number)
    {
        case 1: System.Console.WriteLine("monday"); break;
        case 2: System.Console.WriteLine("tuesday"); break;
        case 3: System.Console.WriteLine("wednesday"); break;
        case 4: System.Console.WriteLine("thursday"); break;
        case 5: System.Console.WriteLine("friday"); break;
        case 6: System.Console.WriteLine("saturday"); break;
        case 7: System.Console.WriteLine("sunday"); break;

        default: System.Console.WriteLine("Bad number"); break;
    }
}
else
{
    System.Console.WriteLine("Bad number");
}