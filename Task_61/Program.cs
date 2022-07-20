/* Вывести первые N строк треугольника Паскаля.
Сделать вывод в виде равнобедренного треугольника. */

void PascalTriangle(int num)
{
    int[,] matr = new int[num, num * 2 + 1];
    matr[0, num] = 1;
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        for (int j = 1; j < (matr.GetLength(1) - 1); j++)
        {
            matr[i, j] = matr[i - 1, j - 1] + matr[i - 1, j + 1];
        }
    }

    //    for (int i = 0; i < matr.GetLength(0); i++)
    //    {
    //        //Более менее норамльный вывод до 13 строки, потом начинает съезжать
    //        for (int j = 0; j < matr.GetLength(1); j++)
    //        {
    //            if (matr[i,j] == 0) Console.Write($"    ");
    //            else if (matr[i,j]<10) Console.Write($"  {matr[i,j]} ");
    //            else if (matr[i,j]<100) Console.Write($" {matr[i,j]} ");
    //            else Console.Write($" {matr[i,j]}");
    //        }
    //        Console.WriteLine();
    //    }

    string[] str = new string[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == 0) str[i] = str[i] + ' ';
            else str[i] = str[i] + Convert.ToString(matr[i, j]);
        }
    }
// Более универсальный, но менее красивый вывод
    for (int i = 0; i < num; i++)
    {
        int leng = (str[num - 1].Length - str[i].Length)/2;
        while (leng>0)
        {
            Console.Write(" ");
            leng--;
        }
        Console.WriteLine(str[i]);
    }
}

Console.WriteLine("Введите количество строк треугольника паскаля.");
Console.Write("N = ");
int n = int.Parse(Console.ReadLine());

PascalTriangle(n);
