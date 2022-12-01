/*
Задача 21: Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите координаты X точки A: ");
bool isParsedXA = double.TryParse(Console.ReadLine(), out double xA);
Console.WriteLine("Введите координаты Y точки A: ");
bool isParsedYA = double.TryParse(Console.ReadLine(), out double yA);
Console.WriteLine("Введите координаты X точки B: ");
bool isParsedXB = double.TryParse(Console.ReadLine(), out double xB);
Console.WriteLine("Введите координаты Y точки B: ");
bool isParsedYB = double.TryParse(Console.ReadLine(), out double yB);

if (!isParsedXA || !isParsedYA || !isParsedXB || !isParsedYB)
{
    Console.WriteLine("Координаты необходимо задать числом");
    return;
}

double distance = getDistanceBetweenPoints(xA, yA, xB, yB);
Console.WriteLine(distance);

double getDistanceBetweenPoints (double xA, double yA, double xB, double yB)
{
    double calculating = ((xB - xA) * (xB - xA)) + ((yB - yA) * (yB - yA));
    double distance = Math.Sqrt(calculating);
    return distance;
} 
