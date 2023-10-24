/*
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве
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
        System.Console.Write(array[i]);
        if (i < array.Length - 1) System.Console.Write(", ");
    }
}

int[] ProductArray(int[] pArr)
{
    int[] result = new int[pArr.Length / 2];
    int sum = 0;
    for (int i = 0; i < pArr.Length / 2; i++)
    {
        sum = pArr[i] * pArr[pArr.Length - 1 - i];
        result[i] = sum;
    }
    return result;
}
int[] userArray = GetArray(6);
PrintArray(userArray);
System.Console.WriteLine();
int[] newArray = ProductArray(userArray);
PrintArray(newArray);


