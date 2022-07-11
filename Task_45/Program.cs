/* Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования. */

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write($"[{arr[i]},");
        else if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.WriteLine($"{arr[i]}]");
    }
}

void CoppyArray(int[] ar1, int[] ar2)
{
    for (int i = 0; i < ar1.Length; i++)
    {
        ar2[i] = ar1[i];
    }
}

int[] array1 = CreateArrayRndInt(5, 1, 10);
int[] array2 = new int[5];
PrintArray(array1);
CoppyArray(array1, array2);
PrintArray(array2);
