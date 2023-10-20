/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
*/
/* Вариант 1
System.Console.Write("Введите число А: ");

int A = Convert.ToInt32(Console.ReadLine());
int summ = 0;

for (int i = 1; i <= A; i++)
{
    summ = summ + i;
}
System.Console.WriteLine(summ);
*/

// Второй вариант
System.Console.Write("Введите число А: ");
int userA = Convert.ToInt32(Console.ReadLine());

int Num(int a)
{
    int summ = 0;
    for (int i = 1; i <= userA; i++)
    {
        summ = summ + i;
    }
    return summ;
}
int userResult = Num(userA);
System.Console.WriteLine(userResult);


