/*
Решение в группах задач:
Задача 18: Напишите программу, которая по заданному номеру
четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

bool isParsedQuarter = int.TryParse(Console.ReadLine(), out int Quarter);
if (!isParsedQuarter)
{
    Console.WriteLine("Номер четверти задается числом");
    return;
}

int GetCoordinatesByQuarter (int Quarter)
