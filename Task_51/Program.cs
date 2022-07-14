/* Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д. */

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] matr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"[{matr[i, j],3} |");
            else if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3} |");
            else Console.WriteLine($"{matr[i, j],3} ]");
        }
    }
}

int SumMainDiagnal(int[,] matr)
{
    int result = 0;
    int minIndex = (matr.GetLength(0) < matr.GetLength(1)) ? matr.GetLength(0) : matr.GetLength(1);
    for (int i = 0; i < minIndex; i++)
    {
        result += matr[i, i];
    }
    return result;
}

int[,] matrix = CreateMatrixRndInt(6, 3, 0, 10);
PrintMatrix(matrix);
int sumDiagnal = SumMainDiagnal(matrix);
Console.WriteLine($"Сумма элементов по диагонали равна {sumDiagnal}");
