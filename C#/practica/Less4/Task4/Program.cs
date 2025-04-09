// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] CreateArray()
{
    int[] array = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = rnd.Next(0, 2);
    }

    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}]");
}

int[] arr = CreateArray();
PrintArray(arr);
