/*
Внутри класса Answer напишите метод FindMax, 
который принимает на вход три числа и выдаёт 
максимальное из этих чисел.
*/

System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int result = a;

if(b > result)
{
    result = b;
}
if(c > result)
{
    result = c;
}
return result;