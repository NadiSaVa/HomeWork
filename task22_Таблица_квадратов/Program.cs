﻿/*
Напишите программу, которая принимает на вход число(N) и 
выдаёт таблицу квадратов чисел от 1 до N.
*/

System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n; i++)
    Console.Write(Math.Pow(i, 2) + " ");
    