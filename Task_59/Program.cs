/* Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
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

int[,] MatrixWithOutMinimum(int[,] matr)
{
    int[,] newMatr = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int minIJ = 0;
    int min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                minIJ = i * 10 + j;
            }
        }
    }
    for (int i = 0, iN = 0; i < (matr.GetLength(0)); i++, iN++)
    {
        if (i == minIJ / 10) i++;
        for (int j = 0, jN = 0; j < (matr.GetLength(1)); j++, jN++)
        {
            if (j == minIJ % 10) j++;
            newMatr[iN, jN] = matr[i, j];
        }
    }
    return newMatr;
}

int[,] matrix = CreateMatrixRndInt(6, 10, -100, 100);
PrintMatrix(matrix);
Console.WriteLine();
int[,] newMatrix = MatrixWithOutMinimum(matrix);
PrintMatrix(newMatrix);
