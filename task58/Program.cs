
/*  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] arrayA;
int[,] arrayB;
int[,] arrayC;

Run();

void Run()
{
    fillData(2, 2, 2);
    PrintArray(arrayA);
    Console.WriteLine();
    PrintArray(arrayB);
    Console.WriteLine();
    MultiplyArrays();
    //Console.WriteLine();
    PrintArray(arrayC);

}

void fillData(int rowCountA, int columnCountA, int columnCountB)
{
    arrayA = new int[rowCountA, columnCountA];
    arrayB = new int[columnCountA, columnCountB];
    arrayA= FillArray(rowCountA, columnCountA, arrayA);
    arrayB= FillArray(columnCountA, columnCountB,  arrayB);

    arrayC = new int[rowCountA, columnCountB];
}

void MultiplyArrays()
{
    int rowCount = arrayC.GetLength(0);
    int columnCount = arrayC.GetLength(1);

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            int sum = 0;
            for(int x=0; x< arrayA.GetLength(1); x++ )
            {
                sum += arrayA[i, x] * arrayB[x, j];
            }
            arrayC[i,j] = sum;
        }
    }
}

int[,] FillArray(int rowCount, int columnCount, int[,] array)
{
    array = new int[rowCount, columnCount];
    Random rnd = new Random();

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
            array[i, j] = rnd.Next(1, 9);
    }
    return array;
}

void PrintArray(int[,] array)
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