/*
1. Напиши программу воторая принимает на вход два числа
и проверяет явяется ли первое число квадратом второго
*/
System.Console.WriteLine("Ведите числа: ");
int userNumb1 = Convert.ToInt32(Console.ReadLine());
int userNumb2 = Convert.ToInt32(Console.ReadLine());

/* int sqNumb2 = userNumb2 * userNumb2;
bool result = userNumb1 == sqNumb2;

Console.WriteLine(result);
*/
// А вот второй вариант
if(userNumb1 == userNumb2 * userNumb2)
{
Console.WriteLine("Yes");
}
else
{
Console.WriteLine("No");
}