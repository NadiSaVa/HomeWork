/*
Напишите программу замены элементов массива: 
положительные элементы замените на соответствующие отрицательные, 
и наоборот
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

int userArraySize = TakeEntNum("Введите размер массива: ");
int userArrayStart = TakeEntNum("Введите начало массива: ");
int userArrayEnd = TakeEntNum("Введите конец массива: ");

int[] userArray = GetArray (userArrayStart, userArrayEnd, userArraySize);
PrintArray (userArray);

//int posSumArray = SumPositivNum(userArray);
//int negSumArray = SumNegativNum(userArray);

//System.Console.WriteLine($"Сумма положительных чисел: {posSumArray}, сумма отрицательных чисел: {negSumArray}.");


