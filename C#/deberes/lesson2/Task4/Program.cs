// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Не использовать строки

// 6 -> да
// 7 -> да
// 1 -> нет

int NumberRequest(string message)
{
    System.Console.WriteLine($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

bool IsDayOfWeek(int num)
{
    return (num > 0 && num < 8);
}

void IsFiesta(int day)
{
    if (!IsDayOfWeek(day)) System.Console.WriteLine("It is not day of week!");
    else
    {
        if (day == 6 || day == 7) System.Console.WriteLine("It is fiesta!");
        else System.Console.WriteLine("It is not fiesta :((");
    }
}

int day = NumberRequest("Enter a day of week");
IsFiesta(day);