// Упорядочить массив (сортировка методом выбора в порядке увеличения значений)
// 6 8 3 2 1 4 5 7

int[] array = { 6, 8, 3, 2, 1, 4, 5, 7, 7, 2, 89 };

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition]) minPosition = j;
        }

        int temp = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temp;
    }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);