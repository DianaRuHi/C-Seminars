/* Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Console.WriteLine("Введите число:");
Console.Write("A = ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
Console.Write("B = ");
int num2 = Convert.ToInt32(Console.ReadLine());

int PowNumbers(int powArg, int powPow)
{
    if (powPow == 0) return 1;
    return powArg*PowNumbers(powArg,powPow-1);
}

int pow = PowNumbers(num1, num2);
Console.WriteLine($"Число {num1} в степени {num2} = {pow}");