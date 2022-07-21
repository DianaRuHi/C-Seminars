/* Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

Console.WriteLine("Введите число:");
Console.Write ("N = ");
int num = Convert.ToInt32(Console.ReadLine());

void Numbers1N(int n)
{
    if (n==0) return;
    Numbers1N (n-1);
    Console.Write ($"{n} ");
}

Numbers1N(num);
