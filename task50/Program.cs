// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//[1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите позицию элемента: ");
string position = Console.ReadLine();
int RowIndex = -1;
int ColumnIndex = -1;
ParsePosition(position.Replace("[","").Replace("]",""));

int[,] array = GetArray(rows, columns, 0,10);
Element(array,RowIndex,ColumnIndex);
Console.WriteLine();
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        result[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
    for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
    Console.WriteLine();
    }
}

void ParsePosition(string position)
{
    string[] strings = position.Split(',');
    RowIndex = int.Parse(strings[0]);
    ColumnIndex = int.Parse(strings[1]);
}

void Element (int [,] array, int i, int j)
{

if (i < array.GetLength(0) && j < array.GetLength(1))
    {
    Console.Write($"Позиция элемента [{i},{j}] имеет значение {array[i, j]}");
    }
else Console.Write($"Такого числа в массиве нет");
}