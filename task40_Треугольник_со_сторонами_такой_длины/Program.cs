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

/* Второй вариант

Console.WriteLine("Введите длины трех сторон треугольника:");
Console.Write("Сторона A: ");
double sideA = double.Parse(Console.ReadLine());

Console.Write("Сторона B: ");
double sideB = double.Parse(Console.ReadLine());

Console.Write("Сторона C: ");
double sideC = double.Parse(Console.ReadLine());

bool isTriangle = IsTriangle(sideA, sideB, sideC);
{
if (isTriangle)
{
Console.WriteLine("Треугольник с такими сторонами существует.");
}
else
{
Console.WriteLine("Треугольник с такими сторонами не существует.");
}
}
bool IsTriangle(double a, double b, double c)
{
return a + b > c && a + c > b && b + c > a;
}
*/
