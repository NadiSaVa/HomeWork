/*
Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
*/

Console.Clear();

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetArray()
{
    int[] array = new int[123];
    for (int i = 0; i < 123; i++)
    {
        array[i] = new Random().Next(0, 1000);
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

int FindNumb(int[] arrayfr)
{
    int count = 0;
    for (int i = 0; i < arrayfr.Length; i++)
    {
        if(arrayfr[i] >= 10 && arrayfr[i] <= 99)
            count++;
    }
    return count;
}
int[] userArray = GetArray();
PrintArray(userArray);
System.Console.WriteLine();
System.Console.WriteLine(FindNumb(userArray));






