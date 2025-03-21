// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8
// 1213-> 3
// 845 -> 8

int GenerateNumber()
{
    return new Random().Next(10, 10000);
}

int[] ToArray(int number)
{
    int[] array = new int[4];
    int i = 0;

    while (i < array.Length)
    {
        array[i] = number % 10;
        number = number / 10;
        i++;
    }
    return array;
}

int LargestNumber(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i]>max) max = arr[i];
    }
    return max;
}

int value = GenerateNumber();
System.Console.WriteLine(value);
System.Console.WriteLine(LargestNumber(ToArray(value)));




