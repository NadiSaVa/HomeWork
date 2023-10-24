/*
Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве
*/

Console.Clear();

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetArray(int start, int end, int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
        System.Console.Write(", ");  
    }
    System.Console.WriteLine("]");
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -1 * array[i];
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
        System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}

bool findNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(num == array[i])
        return true;
    }
    return false;
}

int userArraySize = TakeEntNum("Введите размер массива: ");
int userArrayStart = TakeEntNum("Введите начало массива: ");
int userArrayEnd = TakeEntNum("Введите конец массива: ");

int[] userArray = GetArray (userArrayStart, userArrayEnd, userArraySize);
PrintArray (userArray);

int userNum = TakeEntNum("Какое число ищем ");
System.Console.WriteLine(findNum(userArray, userNum));