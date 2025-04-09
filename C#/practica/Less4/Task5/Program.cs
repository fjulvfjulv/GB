// Напишите программу, которая из массива случайных чисел ищет второй максимум 
// (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом 
// [1, 3, 5, 6, 6, 4] -> 5


int SearchSecondMax(int[] arr)
{
    int firstMax = arr[0];
    int secondMax = int.MinValue;
    int temp;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] > arr[i + 1])
        {
            firstMax = arr[i];
            if (secondMax < arr[i + 1])
            {
                secondMax = arr[i + 1];
            }
        }
        else
        {
            firstMax = arr[i + 1];
            if (secondMax > arr[i])
            {
                secondMax = arr[i];
            }
        }
    }
    if (firstMax > secondMax) return secondMax;

    else return firstMax;
}

int[] array = {1, 3, 5, 6, 6, 4};
int num = SearchSecondMax(array);
System.Console.WriteLine(num);
