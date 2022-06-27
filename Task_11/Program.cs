/* Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98 */

int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {rndNum}");

int MaxDigit(int num)
{
    int firstDigit = num / 100;
    int theDigit = num % 10;
    return firstDigit * 10 + theDigit;
}
Console.WriteLine($"Число нужное вам = {MaxDigit(rndNum)}");
