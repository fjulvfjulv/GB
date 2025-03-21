// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки

// 456 -> 5
// 782 -> 8
// 918 -> 1

int NumberRequest(string message)
{
    System.Console.WriteLine($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

int ModulOfNumber(int number)
{
    if (number < 0) number = -number;
    return number;
}

bool ValidateNumber(int number)
{
    number = ModulOfNumber(number);
    if (number > 99 && number < 1000) return true;
    return false;
}

void TheThird(int number)
{
    number = ModulOfNumber(number);
    if (ValidateNumber(number))
    {
        System.Console.WriteLine($"Answer: {number / 10 % 10}");
    }
    else
    {
        System.Console.WriteLine("A non-three-digit number was entered");
    }
}

int value = NumberRequest("Enter a three-digit number");
System.Console.WriteLine(value);
TheThird(value);