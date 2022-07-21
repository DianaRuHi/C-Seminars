/* Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9 */

Console.WriteLine("Введите число:");
Console.Write("N = ");
int num = Convert.ToInt32(Console.ReadLine());

int SumOfDijits(int number)
{
    if (number == 0) return 0;
    return (number % 10) + SumOfDijits(number / 10);
}
int sum = SumOfDijits(num);
Console.WriteLine($"Сумма цифр числа = {sum}");
