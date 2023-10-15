/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.
*/
System.Console.WriteLine("Ведите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day <= 5 && day > 0)
{
    Console.WriteLine("Это рабочий день!");
}
if(day == 6 || day == 7)
{
    Console.WriteLine("Ура выходной!");
}
else if(day < 1 || day > 7)
{
    Console.WriteLine("Такого дня не существует!");
}


