// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int GetCoordinates(string message)
{
    int result;
    Console.Write(message);
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out int number))
            return number;
        else 
        Console.WriteLine("Вы ввели не число!");
    }
    return result;
}

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double distance = Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2));
    return distance;
}

int xa = GetCoordinates(" Введите координату X первой точки:");
int ya = GetCoordinates(" Введите координату Y первой точки:");
int za = GetCoordinates(" Введите координату Z первой точки:");
int xb = GetCoordinates(" Введите координату X второй точки:");
int yb = GetCoordinates(" Введите координату Y второй точки:");
int zb = GetCoordinates(" Введите координату Z второй точки:");
double distance = Distance(xa,ya,za,xb,yb,zb);
Console.WriteLine($"Расстояние между точками ({xa},{ya},{za}) и ({xb},{yb},{zb}) равняется {Math.Round(distance,2)}");
