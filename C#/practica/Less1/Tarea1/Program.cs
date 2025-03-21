// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine());

int cuadrado = number * number;

System.Console.WriteLine("Квадрат введенного тобой числа " + number + " равен " + cuadrado);