/* Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120 **/

Console.WriteLine("Введите число.");
Console.Write("n = ");
int num = int.Parse(Console.ReadLine());

int Po(int nu)
{
    int po = 1;

    for (int i = 1; i <= nu; i++)
    {
        po *= i;
    }
    return po;
}
int pow = Po(num);
Console.WriteLine($"Произведение чисел от 1 до {num} = {pow}");
