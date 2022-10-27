// Задача 19 Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Является ли число полиндромом ");
Console.WriteLine("Введите число:      ");
int PL = int.Parse(Console.ReadLine()!);

    int temp = PL;
    int b = 0;

    while (temp > 0)
        {   
        b = b * 10 + temp %10;
        temp /= 10;
        }
        if (PL == b)
        {
        Console.WriteLine("Да");
        }
        else 
        {
        Console.WriteLine("Нет");
        }
    