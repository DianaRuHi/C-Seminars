/* Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */

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

void StrokiChangeFirstLast(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        int temp = matr[0, i];
        matr[0, i] = matr[matr.GetLength(0)-1, i];
        matr[matr.GetLength(0)-1, i] = temp;
    }
}

int[,] matrix = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
StrokiChangeFirstLast(matrix);
PrintMatrix(matrix);
