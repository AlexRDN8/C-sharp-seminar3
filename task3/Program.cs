/*
Задача 22: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
int[] array =

5 -> 1, 4, 9, 16, 25. 2 -> 1,4
*/

Console.WriteLine("Введите число: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int N);

if (!isParsedN)
{
    Console.WriteLine("Должно быть введено число");
    return;
}

int[] getSquareOfNumber(int N)
{
    int[] array = new int[N];
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = (int)(Math.Pow(index+1, 2));
        index ++;               
    }
    return array;         
}

int[] squareOfNumber = getSquareOfNumber(N);
void PrintArray (int [] array)
{
    for (int index = 0; index < array.Length; index ++)
    {
        Console.WriteLine($"{array[index]} ");
    }
    Console.WriteLine();
}
PrintArray(squareOfNumber);