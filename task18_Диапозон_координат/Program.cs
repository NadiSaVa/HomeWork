/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/
/*
Задача решена на семинаре

string f(int a)
{
   if (a == 1)
        return "x > 0 && y > 0";
    else if (a == 2)
        return "x < 0 && y > 0";
    else if (a == 3)
        return "x < 0 && y < 0";
    return "x > 0 && y < 0"; 
}
System.Console.Write("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(x));
*/

System.Console.WriteLine("Введите номер четверти: ");
int userCvoter = Convert.ToInt32(Console.ReadLine());

if (userCvoter == 1)
{
    System.Console.WriteLine("Все x и y больше 0");
}
if (userCvoter == 2)
{
    System.Console.WriteLine("Все x меньше 0, y больше 0");
}
if (userCvoter == 3)
{
    System.Console.WriteLine("Все x и y меньше 0");
}
if (userCvoter == 4)
{
    System.Console.WriteLine("Все x больше 0, y меньше 0");
}