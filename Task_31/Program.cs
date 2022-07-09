/* Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20. */

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

int[] GetSumPosNegElem(int[] arr)
{
    int[] arSum = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) arSum[0] = arSum[0] + arr[i];
        else arSum[1] = arSum[1] + arr[i];
    }
    return arSum;
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

void PrintSumPosNeg(int[] arr)
{
    Console.WriteLine($"Суммна положительных членов массива {arr[0]}");
    Console.WriteLine($"Суммна отрицательных членов массива {arr[1]}");
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int[] sumPosNeg = GetSumPosNegElem(array);
PrintSumPosNeg(sumPosNeg);
