/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.Clear();

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Conv(int number)
{
    int result = 0;         //    берем 3
    int temp = 0;           //  
    for (int i = number; i > 0; i/=2)
    {
        temp = i % 2;       // 1 , 1 
        result = temp + result * 10;             //  10 + 1 
    }
    return result;
}
int uNum = TakeEntNum("Введите число: ");
System.Console.WriteLine(Conv(uNum));
