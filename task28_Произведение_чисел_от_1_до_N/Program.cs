/*
Напишите программу, которая принимает на вход число N и 
выдаёт произведение чисел от 1 до N.
*/

System.Console.Write("Введите число А: ");
int userA = Convert.ToInt32(Console.ReadLine());

int Num(int a)
{
    int summ = 1;
    for (int i = 1; i <= userA; i++)
    {
        summ = summ * i;
    }
    return summ;
}
int userResult = Num(userA);
System.Console.WriteLine(userResult);