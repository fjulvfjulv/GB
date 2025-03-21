// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Не использовать строки для расчета

// 456 -> 46
// 782 -> 72
// 918 -> 98

int GenerateNumber()
{
    return new Random().Next(100, 1000);
}

int DeleteSecond(int number)
{
    return (number / 100 * 10 + number % 10);
}

int value = GenerateNumber();
System.Console.WriteLine(value);
System.Console.WriteLine(DeleteSecond(value));