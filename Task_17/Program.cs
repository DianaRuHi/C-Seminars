/* Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка. */

Console.Clear();

Console.WriteLine("Введите координаты точки отличные от 0:");
Console.Write("x = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0) Console.WriteLine("Ошибка ввода");
else if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");

string Quater(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "Ошибка ввода";
}

Console.WriteLine(Quater(x, y));
