/* Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

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

int[] ChengeElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
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

int[] array = CreateArray();
Console.WriteLine("Введенный массив.");
PrintArray(array);
ChengeElements(array);
Console.WriteLine("Массив с заменой элементов на противоположные по знаку.");
PrintArray(array);
