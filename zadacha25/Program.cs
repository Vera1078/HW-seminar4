﻿// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// System.Console.WriteLine("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());

//  double result = Math.Pow((A), B);
//  System.Console.WriteLine($"Число A в степени B = {result}");



Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = A;

for (int i = 1; i < B; i++)
{
result = result * A;
}
Console.WriteLine($"A в степени B = {result}");