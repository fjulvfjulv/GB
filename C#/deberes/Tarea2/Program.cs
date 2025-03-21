// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Enter third number: ");
int num3 = int.Parse(Console.ReadLine());

System.Console.WriteLine(max(num1, num2, num3));


int max(int a, int b, int c)
{
    if (a > b && a > c) return a;
    else if (b > a && b > c) return b;
    else return c;
}