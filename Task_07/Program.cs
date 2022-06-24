﻿/* Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8 */

Console.WriteLine("Введите трехзначное число.");
int n = Convert.ToInt32(Console.ReadLine());
if (n < -999 || (n > -100 && n < 100) || n > 999)
{
    Console.WriteLine("Введеное число не является трехзначным.");
}
else
{
    Console.WriteLine(Math.Abs(n % 10));
}
