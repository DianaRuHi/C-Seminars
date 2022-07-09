/* Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

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

int NumberInGap(int[] arr, int min, int max)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (min <= arr[i] && arr[i] <= max) result += 1;
    }
    return result;
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

int[] array = CreateArrayRndInt(123, -100, 101);
PrintArray(array);

Console.WriteLine($"Количество чисел в диапазоне от 10 до 99 = {NumberInGap(array, 10, 99)}");
