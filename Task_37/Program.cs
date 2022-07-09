/* Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

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

int[] MultiplicationFerstLastArray(int[] arr)
{
    int newLen = arr.Length / 2 + arr.Length % 2;
    int[] arrNew = new int[newLen];
    for (int i = 0; i < newLen; i++)
    {
        arrNew[i] = arr[i] * arr[arr.Length - i - 1];
        //Console.WriteLine(arrNew[i]);
    }
    if (arr.Length % 2 != 0) arrNew[newLen - 1] = arr[newLen - 1];
    return arrNew;
}

int[] array = CreateArrayRndInt(5, 1, 10);
PrintArray(array);
int[] multipleOfArray = MultiplicationFerstLastArray(array);
PrintArray(multipleOfArray);
