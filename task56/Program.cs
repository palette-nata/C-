/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] array;

Run();

void Run()
{
    FillArray(3, 4);
    PrintArray();
    Console.WriteLine();
    FindRowWitjMinimalSum();
    
}

void FillArray(int rowCount, int columnCount)
{
    array = new int[rowCount, columnCount];
    Random rnd = new Random();

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
            array[i, j] = rnd.Next(10, 99);
    }
}

void PrintArray()
{
    int rowCount = array.GetLength(0);
    int columnCount = array.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            if (array[i, j] < 10) Console.Write($"  {array[i, j]}");
            else Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

void FindRowWitjMinimalSum()
{
    int MinSum=int.MaxValue;
    int row = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+= array[i, j];
        }
        if (sum < MinSum)
        {
            MinSum = sum;
            row = i;
        }
    }
    Console.WriteLine($"Минимальная сумма={MinSum} строки {row+1}");
    
}

       