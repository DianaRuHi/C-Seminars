/* Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

int TenToTwo(int n)
{
    if (n == 1) return 1;
    if (n == 0) return 0;
    return n % 2 + 10 * TenToTwo(n / 2);
}

Console.WriteLine("Введите число двоичную форму которого хотите получить.");
Console.Write("n = ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{num} = {TenToTwo(num)} ");
