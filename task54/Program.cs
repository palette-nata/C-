//  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array;

Run();

void Run()
{
    FillArray(3, 4);
    PrintArray();
    Console.WriteLine();
    SortArray();
    PrintArray();
}

    void FillArray(int rowCount, int columnCount)
{
    array = new int[rowCount, columnCount];
    Random rnd = new Random();

    for (int i=0; i<rowCount; i++)
    {
        for(int j=0; j<columnCount; j++)
            array[i,j] = rnd.Next(10, 99);
            
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

void SortArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = array[i, j];
            int col = j;

            for (int x = j; x < array.GetLength(1); x++)
            {
                if (array[i, x] > max)
                {
                    max = array[i, x];
                    col = x;
                }
            }
            int temp = array[i, j];
            array[i, j] = max;
            array[i, col] = temp;
        }
    }
}
