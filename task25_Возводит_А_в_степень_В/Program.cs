/*
Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B
*/

Console.Clear();
System.Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

/*
void NatStep(int a, int b)
{
    double result = Math.Pow(a, b);
    System.Console.WriteLine(result);
}
NatStep(numA, numB);
*/

// решение с циклами
void NatStep(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    System.Console.WriteLine(result);
}
NatStep(numA, numB);