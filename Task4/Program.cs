/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22   */

Console.Write("Введите первое число: а = ");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);

Console.Write("Введите второе число: b = ");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);

Console.Write("Введите третье число: c = ");
string numberStr3 = Console.ReadLine();
int c = Convert.ToInt32(numberStr3);

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"max = {max}");
