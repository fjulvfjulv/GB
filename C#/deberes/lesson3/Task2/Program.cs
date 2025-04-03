// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double RequestNumber(string msg)
{
    Console.WriteLine($"{msg} ");
    return Convert.ToDouble(Console.ReadLine());
}

double[] RequestPoints()
{
    double[] points = new double[6];
    {
        for (int i = 1; i < 3; i++)
        {
            points[i - 1] = RequestNumber($"Enter coordinate X for the point {i}");
        }
        for (int i = 1; i < 3; i++)
        {
            points[i + 1] = RequestNumber($"Enter coordinate Y for the point {i}");
        }
        for (int i = 1; i < 3; i++)
        {
            points[i + 3] = RequestNumber($"Enter coordinate Z for the point {i}");
        }
    }
    return points;
}


double[] FindDiference(double[] points)
{
    double[] diference = new double[3];
    diference[0] = points[1] - points[0];
    diference[1] = points[3] - points[2];
    diference[2] = points[5] - points[4];

    return diference;
}

double FindDistance(double[] points)
{
    double[] dif = FindDiference(points);
    double sum = 0;
    for (int i = 0; i < dif.Length; i++)
    {
        sum += dif[i] * dif[i];
    }

    return Math.Sqrt(sum);
}

double[] points = RequestPoints();
double dist = FindDistance(points);
System.Console.WriteLine(dist);




