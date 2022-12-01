/*
Решение в группах задач:
Задача 18: Напишите программу, которая по заданному номеру
четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
Console.WriteLine("Введите номер четверти координат числом от 1 до 4: ");
bool isParsedQuarter = int.TryParse(Console.ReadLine(), out int Quarter);
if (!isParsedQuarter)
{
    Console.WriteLine("Номер четверти задается числом");
    return;
}
string Coordinates = GetCoordinatesByQuarter (Quarter);
Console.WriteLine(Coordinates);

string GetCoordinatesByQuarter (int Quarter)
{
    if (Quarter == 1)
    {
     return $"Четверти {Quarter} соответствуют координаты x > 0 && y > 0"; 
    }
    if (Quarter == 2)
    {
     return $"Четверти {Quarter} соответствуют координаты x < 0 && y > 0"; 
    }
    if (Quarter == 3)
    {
     return $"Четверти {Quarter} соответствуют координаты x < 0 && y < 0"; 
    }
    if (Quarter == 4)
    {
     return $"Четверти {Quarter} соответствуют координаты x > 0 && y < 0"; 
    }
    return "Число должно быть от 1 до 4";
}
