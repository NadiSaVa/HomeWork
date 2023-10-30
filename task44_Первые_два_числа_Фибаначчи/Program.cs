/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Write("Введите количество чисел Фибоначчи: ");
int n = int.Parse(Console.ReadLine());

if (n < 1)
{
Console.WriteLine("Пожалуйста, введите положительное число.");
return;
}

int first = 0;
int second = 1;

Console.Write("Первые " + n + " чисел Фибоначчи: ");

if (n >= 1)
{
Console.Write(first);
}

if (n >= 2)
{
Console.Write(", " + second);
}

for (int i = 3; i <= n; i++)
{
int next = first + second;
Console.Write(", " + next);
first = second;
second = next;
}

Console.WriteLine();
