/* Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

Console.WriteLine("Введите число.");
Console.Write("n = ");
int num = int.Parse(Console.ReadLine());

int Coli(int n)
{
    int result = 0;
    if (n == 0) result = 1;
    while (Math.Abs(n) > 0)
    {
        n = n / 10;
        result += 1;
    }
    return result;
}

int col = Coli(num);
Console.WriteLine($"Количество цифр в числе {num} равно {col}");
