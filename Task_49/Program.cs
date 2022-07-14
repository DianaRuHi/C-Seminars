/* Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты. */

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"[{arr[i, j],3} |");
            else if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} |");
            else Console.WriteLine($"{arr[i, j],3} ]");
        }
    }
}

void MatrixEvenIndexPow(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i+=2)
    {
        for (int j = 0; j < matr.GetLength(1); j+=2)
        {
            matr[i, j] = matr[i,j]*matr[i,j];
        }
    }
}

int[,] matrix = CreateMatrixRndInt(3, 4, 2, 9);
PrintMatrix(matrix);
Console.WriteLine();
MatrixEvenIndexPow(matrix);
PrintMatrix(matrix);
