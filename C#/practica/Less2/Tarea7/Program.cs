// Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 

int NumberRequest(string message)
{
    System.Console.WriteLine($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] ToArray()
{
    int[] arr = new int[5];
    int i = 0;
    while (i < 5)
    {
        arr[i] = NumberRequest("Enter number:");
        i++;
    }
    return arr;

}
double SumOfNumbers(int[] arr)
{
    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}

double Average(int[] arr)
{
    return SumOfNumbers(arr) / arr.Length;
}

int[] array = ToArray();
System.Console.WriteLine(SumOfNumbers(array));
System.Console.WriteLine(Average(array));