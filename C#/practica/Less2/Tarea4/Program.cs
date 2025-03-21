// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int NumberRequest(string message)
{
    System.Console.WriteLine($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

void IsMultiple(int number)
{
    if (number % 7 == 0 && number % 23 == 0)

    {
        System.Console.WriteLine($"Number {number} is a multiple of numbers 7 and 23");
    }
    else
    {
        System.Console.WriteLine($"Number {number} is not a multiple of numbers 7 and 23");
    }
}

IsMultiple(NumberRequest("Enter number"));