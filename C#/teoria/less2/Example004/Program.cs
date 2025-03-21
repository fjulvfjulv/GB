
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(arr[position]);
        position++;
    }
}

int IndexOf(int[] arr, int find)
{
    int count = arr.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (arr[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 88);
Console.WriteLine(pos);