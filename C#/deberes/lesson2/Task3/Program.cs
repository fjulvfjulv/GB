// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. . Не использовать строки

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int NumberRequest(string message)
{
    System.Console.WriteLine($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateNumber(int number)
{
    return number >= 100;
}


void ThirdDigit(int num)
{
    int value;
    if (ValidateNumber(num))
    {
        while (num >= 1000)
        {
            num /= 10;
        }
        value = num % 10;
        System.Console.WriteLine(value);
    }
    else System.Console.WriteLine("There is no third digit in this number");
}

int value = NumberRequest("Enter the number");
System.Console.WriteLine(value);
ThirdDigit(value);

