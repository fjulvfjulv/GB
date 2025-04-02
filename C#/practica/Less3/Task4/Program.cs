// Напишите программу, которая генерирует последовательность случайных чисел 
// из 10 элементов в диапазоне от 1 до 10, и подсчитывает, сколько сгенерировалось чисел больше 5.


int[] GenerateArray()
{
    int[] array = new int[10];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
    }

    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int More5(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 5) count++;
    }
    return count;
}

int[] array = GenerateArray();
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(More5(array));