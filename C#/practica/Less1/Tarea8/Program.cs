// Составить программу, которая выводит числа от 1 до 100, 
// если число кратно 3, то вместо числа пишет FIZZ, 
// если число кратно 5, то пишем BUZZ, 
// если число кратно и 3 и 5, то пишем FIZZBUZZ

int count = 1;

while (count <= 100)
{
    if (isBUZZ(count) | isFIZZ(count)) System.Console.WriteLine();
    else System.Console.WriteLine(count);
    count++;
}

bool isFIZZ(int num)
{
    if (num % 3 == 0)
    {
        System.Console.Write("FIZZ");
        return true;
    }
    return false;
}

bool isBUZZ(int num)
{
    if (num % 5 == 0)
    {
        System.Console.Write("BUZZ");
        return true;
    }
    return false;
}