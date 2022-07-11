/* Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

void FibonachiNum(int n)
{
    int f0 = 0, f1 = 1;
    if (n >= 1) Console.Write($"{f0} ");
    if (n >= 2) Console.Write($"{f1} ");
    for (int i = 3; i <= n; i++)
    {
        Console.Write($"{f0 + f1} ");

        if (f0 <= f1) f0 = f0 + f1;
        else if (f1 < f0) f1 = f1 + f0;
    }
}

Console.WriteLine("Введите количество чисел фибоначи которые хотите получить.");
Console.Write("n = ");
int num = int.Parse(Console.ReadLine());

FibonachiNum(num);
