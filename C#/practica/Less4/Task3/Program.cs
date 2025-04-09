// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int RequestNumber(string msg)
{
    Console.WriteLine($"{msg} ");
    return Convert.ToInt32(Console.ReadLine());
}

int CountingMult(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult *= i;
    }
    return mult;
}

int Recursion(int num)
{
    if (num <= 1) return 1;
    else return num * Recursion(num - 1);
}

int number = RequestNumber("Enter a number");
System.Console.WriteLine(CountingMult(number));
System.Console.WriteLine("----------------");
System.Console.WriteLine(Recursion(number));
