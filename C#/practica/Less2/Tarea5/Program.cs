// Напишите программу, которая генерирует несколько случайных чисел, 
// и в цикле проверяет, кратны ли эти числа предварительно введенному числу, 
// при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет 
// 15 -> нет 
// 12 -> да


void Check(int value)
{
    do
    {
        int number = new Random().Next();
        if (number % value == 0)
        {
            System.Console.WriteLine($"Number {number} is a multiple of number {value}");
            break;
        }
        else
        {
            System.Console.WriteLine($"Number {number} is not a multiple of number {value}");
        }
    }
    while(true);
}

Check(100);
