/* Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

int[] CreateArray()
{
    Console.WriteLine("Введите длину массива.");
    Console.Write("length = ");
    int len = int.Parse(Console.ReadLine());
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        Console.WriteLine($"Введите значение {i + 1}-го злемента массива  массива.");
        Console.Write($"[{i + 1}] = ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

void SerchForNumber(int[] arr, int n)
{
    int paper = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == n)
        {
            paper = 1;
            break;
        }
    }
    if (paper == 1) Console.WriteLine($"Да, число {n} присутствует в массиве.");
    else Console.WriteLine($"Нет, число {n} не присутствует в массиве.");
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

int[] array = CreateArray();

Console.WriteLine("Введите искомое число.");
Console.Write("n = ");
int num = int.Parse(Console.ReadLine());

PrintArray(array);
SerchForNumber(array, num);
