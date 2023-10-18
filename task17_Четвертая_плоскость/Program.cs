/*
Напишите программу, которая принимает на вход координаты 
точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
в которой находится эта точка.
*/


/* Решение на семинаре

string f(int x, int y)
{
    if (x > 0 && y > 0)
        return "I";
    else if (x < 0 && y > 0)
        return "II";
    else if (x < 0 && y < 0)
        return "III";
    return "IV";
}

System.Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(x, y));

*/

// Решение с Валерией

System.Console.Write("Введите координаты точки x: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты точки y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    System.Console.WriteLine("I");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("II");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("III");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("IV");
}
else if (x == 0 || y == 0)
{
    System.Console.WriteLine("Точка находится на оси координат");
}
