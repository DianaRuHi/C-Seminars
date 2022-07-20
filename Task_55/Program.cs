/* Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */


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

void StrokiChangeNaStolbsi(int[,] matr)
{
    if (matr.GetLength(0) != matr.GetLength(1)) Console.WriteLine("Заменить строки на столбцы невозможно");
    else
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = i; j < matr.GetLength(1); j++)
            {
                int temp = matr[i, j];
                matr[i, j] = matr[j, i];
                matr[j, i] = temp;
            }
        }
    }
}

int[,] matrix = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
StrokiChangeNaStolbsi(matrix);
PrintMatrix(matrix);

