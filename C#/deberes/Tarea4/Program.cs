// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

int count = 2;
while (count <= num)
{
    if (count % 2 == 0) System.Console.WriteLine(count);
    count++;
}