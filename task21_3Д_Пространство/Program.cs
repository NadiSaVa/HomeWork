/*
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
*/
/* 
System.Console.Write("Введите координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
Console.Write(d);
*/
//double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
//Console.Write(Math.Round(d, 2));

System.Console.WriteLine("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
   System.Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
}