// Напишите программу, которая выводит первые заданные элемента следующей последовательности:
// -> 12
// 1 2 2 3 3 3 4 4 4 4 5 5

int RequestNumber(string msg)
{
    Console.WriteLine($"{msg} ");
    return Convert.ToInt32(Console.ReadLine());
}

bool IsFull(int[] array)
{
    foreach (int item in array)
    {
        if (item == 0)
        {
            return false;
        }
    }
    return true;
}


int[] GenerateSequenceOfNumbers(int number)
{
    int[] array = new int[number];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 0)
        {
            count++;
            for (int j = 0; j <= i; j++)
            {
                if (!(IsFull(array))) array[i + j] = count;
            }
        }
    }
    return array;
}

void Generate(int number)
{
    int i = 1;
    int count = 0;

    while (i < number)
    {
        while (count < number)
        {
            int j = 0;
            while (j < i)
            {
                System.Console.Write($"{i} ");
                j++;
            }
            i++;
            count++;
        }
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int num = RequestNumber("Enter your number:");
Generate(num);
// PrintArray(arr);