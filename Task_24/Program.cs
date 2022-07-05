/* Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

Console.WriteLine("Введите натуральное число.");
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());

int Sum(int num)
{
    int su = 0;

    for (int i = 1; i <= num; i++)
    {
        su += i;
    }
    return su;
}
int sum = Sum(a);
Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");
