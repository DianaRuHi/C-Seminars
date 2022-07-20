/* Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */

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

void FrequencyDictionary(int[,] matr)
{
    int[] arr = new int[matr.GetLength(0) * matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[i * matr.GetLength(1) + j] = matr[i, j];
        }
    }

    int minI = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        minI = i;
        for (int j = i; j < arr.Length; j++)
        {
            if (arr[j] < arr[minI]) minI = j;
        }
        int temp = arr[i];
        arr[i] = arr[minI];
        arr[minI] = temp;
    }

    int index = 0;
    int k = 1;
    while (index < (arr.Length - 1))
    {
        if (arr[index] == arr[index + 1]) k += 1;
        else
        {
            Console.WriteLine($"Элемент {arr[index]} встречается {k} раз.");
            k = 1;
        }
        index++;
        if (index == (arr.Length - 1))
            Console.WriteLine($"Элемент {arr[index]} встречается {k} раз.");
    }
}

int[,] matrix = CreateMatrixRndInt(6,8,-10,10);
PrintMatrix(matrix);
FrequencyDictionary(matrix);
