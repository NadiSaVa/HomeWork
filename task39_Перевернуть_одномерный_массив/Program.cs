﻿/*
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
Комментарий: эту задачу можно решить 2 способами: 
1) менять числа местами в исходном массиве; 
2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.
*/

Console.Clear();

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

void Revers(int[] array)
{
int temp = 0;
for (int i = 0; i < array.Length / 2; i++)
{
    temp = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = array[i];
    array[i] = temp;
}
}

int size = TakeEntNum("Задай размер массива: ");
int[] useerArray = GetArray(size);
PrintArray(useerArray);
System.Console.WriteLine();
Revers(useerArray);
PrintArray(useerArray);