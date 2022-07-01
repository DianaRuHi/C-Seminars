/* Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

Console.WriteLine("Введите натуральное число.");
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1) Console.WriteLine("Ошибка ввода");
else
{
    int index = 1;
    while (index < n)
    {
        Console.Write($"{Math.Pow(index, 2)}, ");
        index++;
    }
    Console.WriteLine($"{Math.Pow(n, 2)}");
}
