﻿/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8  */

Console.Write("Введите первое число: N = ");
string numberStr1 = Console.ReadLine();
int N = Convert.ToInt32(numberStr1);

for (int i = 2; i <= N; i = i + 2)
{
    Console.Write(i + ", ");
}