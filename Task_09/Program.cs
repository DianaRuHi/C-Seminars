/* Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8 */


int randNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число {randNum}");

int dig1 = randNum % 10;
int dig2 = randNum / 10;
digMax = dig1 > dig2 ? dig1 : dig2;

//if (dig1 > dig2) Console.WriteLine($"Наибольшая цифра числа {randNum} => {dig1}");
//else if (dig2 > dig1) ($"Наибольшая цифра числа {randNum} => {dig2}");
//else ($"Цифры числа одинаковы {randNum} => {dig1}");

if (dig1 == dig2) ($"Цифры числа {randNum} одинаковы");
else ($"Наибольшая цифра числа {randNum} => {digMax}");
