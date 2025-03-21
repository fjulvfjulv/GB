// Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int GenerateNumber()
{
    return new Random().Next(10, 100);
}

int LargestNumber(int num)
{
    if (num % 10 > num / 10) return num % 10;
    return num / 10;
}

int number = GenerateNumber();
System.Console.WriteLine(number);
System.Console.WriteLine(LargestNumber(number));