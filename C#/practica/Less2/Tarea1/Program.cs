//  Напишите программу, которая принимает на вход трёхзначное число 
//  и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    int answer = Convert.ToInt32(Console.ReadLine());

    return answer;
}

int ModulOfNumber(int num)
{
    if (num < 0)
    {
        num = -num;
    }
    return num;
}

bool ValidateNumber(int num)
{
    int number = ModulOfNumber(num);
    if (number >= 100 && number < 1000)
    {
        return true;
    }
    else
    {
        System.Console.WriteLine("Введено не трехзначное число");
        return false;
    }
}

void LastNumber(int num)
{
    if (ValidateNumber(ModulOfNumber(num)))
    {
        int result = ModulOfNumber(num) % 10;
        System.Console.WriteLine(result);
    }
}


int number = Prompt("Enter number");
LastNumber(number);
