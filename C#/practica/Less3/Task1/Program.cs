// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.


void RequestInformation(string msg)
{
    Console.WriteLine($"{msg} ");
}

double[] CreatePoint()
{
    double[] array = new double[2];
    RequestInformation("Enter the X coordinate of the point:");
    array[0] = Convert.ToDouble(Console.ReadLine());
    RequestInformation("Enter the Y coordinate of the point:");
    array[1] = Convert.ToDouble(Console.ReadLine());

    return array;
}

int ShowQuarter(double[] arr)
{
    if (arr[0] > 0 && arr[1] > 0) return 1;
    else if (arr[0] < 0 && arr[1] > 0) return 2;
    else if (arr[0] < 0 && arr[1] < 0) return 3;
    else if (arr[0] > 0 && arr[1] < 0) return 4;
    else
    {
        System.Console.WriteLine("Non-coordinate point values ​​entered");
        return -1;
    }
}

System.Console.WriteLine(ShowQuarter(CreatePoint()));