// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

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

double DistanceSearch(double[] array1, double[] array2)
{
    double x1 = array1[0];
    double y1 = array1[1];
    double x2 = array2[0];
    double y2 = array2[1];

    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}

double[] point1 = CreatePoint();
double[] point2 = CreatePoint();

System.Console.WriteLine(DistanceSearch(point1, point2));