/* Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Amn = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

int[,] CreateMatrixMPlusN(int m, int n)
{
    int[,] arr = new int[m, n];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
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

int[,] matrix = CreateMatrixMPlusN(10, 10);
PrintMatrix(matrix);
