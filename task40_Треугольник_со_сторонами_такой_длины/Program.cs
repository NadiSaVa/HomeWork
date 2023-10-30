/*
Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
*/

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool Triagle(int a, int b, int c)
{
    bool result = false;
    if (a + b > c && a + c > b && b + c > a)
    {
        result = true;
    }
    return result;
}

int userA = TakeEntNum("Введите число А: ");
int userB = TakeEntNum("Введите число B: ");
int userC = TakeEntNum("Введите число C: ");
System.Console.WriteLine(Triagle(userA, userB, userC));


