/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/

Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
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
}

void SumNegIdx(int[] arr)
{
    int summ = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        summ = arr[i] + summ;
    }
    System.Console.WriteLine(summ);
}

int[] array = GetRnd(5);
PrintArray(array);
System.Console.WriteLine();
SumNegIdx(array);

