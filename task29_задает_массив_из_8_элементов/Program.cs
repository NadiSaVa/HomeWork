﻿/*
Напишите программу, которая зарашивает размеер массива и диапозон и выводит их на экран
*/

Console.Clear();

int[] GetArray(int start, int end, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
void PrintArray(int[] arr)
{
    Console.ForegroundColor=ConsoleColor.Red;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
        System.Console.Write(", ");  
    }
    System.Console.Write("]");
    Console.ForegroundColor=ConsoleColor.White;
}

System.Console.WriteLine("Введи диапозон массива от: ");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи диапозон массива до: ");
int userEnd = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetArray(userStart, userEnd, userSize);
PrintArray(userArray);
