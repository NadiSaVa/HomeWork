/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/

Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        //array[i] = new Random().Next(100, 1000);
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ResetColor();
}

void CountPos(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) count++;
    }
    System.Console.WriteLine(count);
}

int[] array = GetRnd(10);
PrintArray(array);
System.Console.WriteLine();
CountPos(array);
//int[] arrayTwo = {4, 5, 7};
//PrintArray(arrayTwo);
