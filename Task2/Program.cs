/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3   */

Console.Write("Введите первое число: а = ");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);

Console.Write("Введите второе число: b = ");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);

if (a > b)
{
    Console.WriteLine($"a = {a} > b = {b} ");
}
else if (a == b)
{
    Console.WriteLine($"a = {a} = b = {b} ");
}
else 
{
    Console.WriteLine($"a = {a} < b = {b} ");
}