// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

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

void CreateCubes(int num)
{
    for (int i = 1; i <= ModulOfNumber(num); i++)
    {
        if (num < 0)
        {
            Console.Write($"{-i * i * i}  ");
            }
        else
        {
            Console.Write($"{i * i * i}  ");
            }
    }
}

int number = RequestNumber("Enter your number");
CreateCubes(number);