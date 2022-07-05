/* Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

Console.WriteLine("Введите длину массива.");
Console.Write("length = ");
int leng = int.Parse(Console.ReadLine());

int[] Colle(int len)
{
    int[] arr = new int[len];
    var rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

void Prin(int[] ar)
{
    Console.Write("[");
    for (int i = 0; i < ar.Length - 1; i++)
    {
        Console.Write($"{ar[i]},");
    }
    Console.Write($"{ar[ar.Length - 1]}]");
}

int[] array = Colle(leng);
Prin(array);
