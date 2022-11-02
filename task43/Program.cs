// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите значение b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = int.Parse(Console.ReadLine());
Point2D point = IntersectionPoint(b1, k1, b2, k2);
Console.WriteLine($"Точка пересечения двух прямых: ({point.x}, {point.y})");

Point2D IntersectionPoint(double b1, double k1, double b2, double k2)
{
    Point2D point = new Point2D();
    point.x =  -(b1 - b2) / (k1 - k2);
    point.y =  k1 * point.x + b1;
    return point;
}
public struct Point2D
{
    public double x;
    public double y;
}