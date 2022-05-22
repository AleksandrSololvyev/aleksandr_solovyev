//Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между 
//ними в 3D пространстве.

int GetNumber(string msg)
{
    while(true)
{
    Console.WriteLine(msg);
    string valueFromConsole = Console.ReadLine();

    if(int.TryParse(valueFromConsole, out int number))
    {
        return number;
    }
    else
    {
       Console.WriteLine("Это не число.");  
    }
}
}
double GetLength(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double difx = Math.Pow((x2 - x1), 2);
    double dify = Math.Pow((y2 - y1), 2);
    double difz = Math.Pow((z2 - z1), 2);
    double length = Math.Sqrt(difx + dify + difz);
    return length;
}
int x1 = GetNumber("Введите координату x первой точки: ");
int y1 = GetNumber("Введите координату y первой точки: ");
int z1 = GetNumber("Введите координату z первой точки: ");
int x2 = GetNumber("Введите координату x второй точки: ");
int y2 = GetNumber("Введите координату y второй точки: ");
int z2 = GetNumber("Введите координату z второй точки: ");

double result = GetLength(x1, y1, z1, x2, y2, z2);
Console.WriteLine(result);
