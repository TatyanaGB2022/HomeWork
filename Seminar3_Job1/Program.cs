﻿// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        System.Console.WriteLine($"{number} - Является палиндромом");
    }
    else
    {
        System.Console.Write($"{number} - Не является палиндромом");
    }
}
else
{
    System.Console.Write($"{number} - не является пятизначным");
}