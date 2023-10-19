/*
Напишите программу, которая принимает на вход 
пятизначное число и проверяет, 
является ли оно палиндромом.
*/

/* 
System.Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000;
//System.Console.WriteLine(n1);
int n2 = n / 1000 % 10;
//System.Console.WriteLine(n2);
int n4 = n / 10 % 10; 
//System.Console.WriteLine(n4);
int n5 = n  % 10;
//System.Console.WriteLine(n5);
if (n >= 10000 & n <= 99999)
{
    if (n1 == n5 & n2 == n4)
    {
        System.Console.Write("Yes");
    }
    else
    System.Console.Write("No");
}
else
{
    System.Console.WriteLine("Here's not five digit!");
}

*/

System.Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int revN = 0;
for (int i = n; i > 0; i /= 10)
{
    revN = revN * 10 + i % 10;
    //System.Console.WriteLine(revN);
}
if (n == revN)
System.Console.WriteLine("YES");
else System.Console.WriteLine("NO");


