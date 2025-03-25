// Упорядочить массив (сортировка методом выбора в порядке уменьшения значений)
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

void SelectionArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}
PrintArray(array);
SelectionArray(array);
PrintArray(array);
