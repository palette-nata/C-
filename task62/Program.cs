// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int[,] array;

int rowCount = 4;
int columnCount = 4;
array = new int[rowCount, columnCount];


MoveState state = MoveState.Right;
int i = 0; 
int j = 0;
int leftBorder = 0;
int upBorder = 0;
int rightBorder = columnCount-1;
int bottomBorder = rowCount-1;
int maxX = rowCount * columnCount;

for (int x = 1; x <= maxX; x++)
{

    array[i, j] = x;

    switch (state)
    {
        case MoveState.Right:
            if (j++ < rightBorder-1);
            else
            {
                upBorder++;
                state = MoveState.Down;
            }
            break;
        case MoveState.Down:
            if (i++ < bottomBorder-1);
            else
            {
                rightBorder--;
                state = MoveState.Left;
            }
            break;
        case MoveState.Left:
            if (j-- > leftBorder+1);
            else
            {
                bottomBorder--;
                state = MoveState.Up;
            }
            break;
        case MoveState.Up:
            if (i-- > upBorder+1);
            else
            {
                leftBorder++;
                state = MoveState.Right;
            }
            break;
    }
}

PrintArray(array);

void PrintArray(int[,] array)
{
    int rowCount = array.GetLength(0);
    int columnCount = array.GetLength(1);

    for(int i=0; i<rowCount; i++)
    {
        for(int j=0; j<columnCount; j++)
        {
            if (array[i, j]<10) Console.Write($"  {array[i, j]}");
            else Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

enum MoveState
{
    Right,
    Left,
    Up,
    Down
}