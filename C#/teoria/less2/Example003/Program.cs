// Имеется одномерный массив array из n элементов,
// требуется найти элемент массива, равный find

int[] array = { 1, 21, 35, 89, 56, 8, 29, 31, 7 };

int n = array.Length;
int find = 56;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

