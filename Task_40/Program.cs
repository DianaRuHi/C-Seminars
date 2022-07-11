/* Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон. */

Console.WriteLine("Введите три числа для длин сторон треугольника.");
Console.Write("a = ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("b = ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("c = ");
int num3 = int.Parse(Console.ReadLine());

if (num1 + num2 <= num3 || num2 + num3 <= num1 || num3 + num1 <= num2) Console.WriteLine("Треугольник с такими сторонами не может существовать.");
else Console.WriteLine("Такой треугольник может существовать.");
