// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли второе число квадратом первого.
// a = 5; b = 25 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> нет
// a = -3 b = 9 -> да

Console.Write("Enter number 1: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter number 2: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 * num1 == num2)
{
    System.Console.WriteLine("Второе число " + num2 + " является квадратом первого " + num1);
}
else
{
    System.Console.WriteLine("Второе число " + num2 + " не является квадратом первого " + num1);
}