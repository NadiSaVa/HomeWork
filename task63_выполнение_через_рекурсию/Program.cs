﻿/*
63. Выполнение через рекурсию (функция вызывает саму себя)

Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void intN(int number, int current = 1)
{
if (number < current) return;
else
{
System.Console.Write(current + " ");
intN(number, current + 1);
}
}

intN(number);