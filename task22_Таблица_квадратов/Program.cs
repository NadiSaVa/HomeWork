/*
Напишите программу, которая принимает на вход число(N) и 
выдаёт таблицу квадратов чисел от 1 до N.
*/

/*
На семинаре
System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n; i++)
    Console.Write(Math.Pow(i, 2) + " ");
*/

// А вот это с Валерией

/*System.Console.Write("Введите число: ");
int userNumb = int.Parse(Console.ReadLine());

for (int i = 1; i <= userNumb; i++)
{
    System.Console.WriteLine($"(i) * (i) = (Math.Pow(i, 2))");
}
*/

// А вот правильное решение
System.Console.WriteLine("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
   System.Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
}