﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine ());

int sum = 0;

while (number > 0)
{
    int num = number % 10;
    number = number / 10;
    sum = sum + num;
}
System.Console.WriteLine($"Сумма цифр числа = {sum}");

        