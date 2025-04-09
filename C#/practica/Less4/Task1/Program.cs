// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int RequestNumber(string msg)
{
    Console.WriteLine($"{msg} ");
    return Convert.ToInt32(Console.ReadLine());
}

int CountingAmount(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int Recursion(int num)
{
    if (num <= 1) return num;
    else return num + Recursion(num - 1);
}

int number = RequestNumber("Enter the number");
System.Console.WriteLine(CountingAmount(number));
System.Console.WriteLine(Recursion(number));
