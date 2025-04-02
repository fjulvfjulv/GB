// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int RequestNumber(string msg)
{
    Console.WriteLine($"{msg} ");
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckNumber(int number)
{
    if (number > 9999 && number <= 99999) return true;
    return false;
}

void IsPalindrom(int number)
{
    if (!CheckNumber(number))
    {
        System.Console.WriteLine("Enter correct number");
    }
    else
    {
        if ((number / 10000 == number % 10) && ((number / 1000) % 10 == ((number / 10) % 10)))
        {
            System.Console.WriteLine($"The number {number} is a palindrom");
        }
        else
        {
            System.Console.WriteLine($"The number {number} is not a palindrom");
        }
    }
}

int number = RequestNumber("Enter your number");
IsPalindrom(number);