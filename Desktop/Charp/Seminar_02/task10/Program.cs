﻿//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("ВВедите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = (number/10)%10;
System.Console.WriteLine($"Вторая цифра числа: {sumNumber}");
