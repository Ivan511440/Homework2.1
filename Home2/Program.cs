﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндроном.

// 14212 → нет
// 12821 → да
// 23432 → да

Console.WriteLine("Введите число:");
string? number = Console.ReadLine();
int len =  number!.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
      {
        Console.WriteLine($"{number} - Палиндрон");
      }
      else
      {
           Console.WriteLine($"{number} - Не палиндрон");
      }
}
else
{
    Console.WriteLine($"Ошибка:{number} - не является пятизначным");
}







