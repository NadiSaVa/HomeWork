/* 7. Напишите программу, которая принимает на вход трехзначноечисло
 и на выходе паказывает последнюю цыфру этого числа
*/

System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = userNumber % 10;
System.Console.WriteLine(result);
