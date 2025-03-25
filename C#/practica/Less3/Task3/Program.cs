// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int RequestNumber(string msg)
{
    Console.WriteLine($"{msg} ");
    return Convert.ToInt32(Console.ReadLine());
}

int ModulOfNumber(int num)
{
    if (num < 0) return -num;
    return num;
}

void CreateQuarters(int number)
{
    number = ModulOfNumber(number);
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{i * i} ");
    }
}

int number = RequestNumber("Enter the number:");
CreateQuarters(number);
