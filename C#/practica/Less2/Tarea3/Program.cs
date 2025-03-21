// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int NumberRequest(string message)
{
    System.Console.WriteLine($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

bool IsMultiple(int number1, int number2)
{
    if (number1 % number2 == 0) return true;
    return false;
}

void Display(int num1, int num2)
{
    if (IsMultiple(num1, num2))
    {
        System.Console.WriteLine($"Number {num1} is a multiple of number {num2}");
    }
    else
    {
        System.Console.WriteLine($"Number {num1} is not a multiple of number {num2}, the remainder is {num1 % num2}");
    }
}

int value1 = NumberRequest("Enter first number");
int value2 = NumberRequest("Enter second number");
Display(value1, value2);