// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int RequestNumber(string msg)
{
    Console.WriteLine($"{msg} ");
    return Convert.ToInt32(Console.ReadLine());
}

int CountingNumders(int num)
{
    int count = 0;

    while (num >= 1)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int count = 0;
int Recursion(int num)
{
    if (num < 1) return count;
    else
    {
        count++;
        return Recursion(num / 10);
    }

}

int number = RequestNumber("Enter a number");
System.Console.WriteLine(CountingNumders(number));
System.Console.WriteLine(Recursion(number));