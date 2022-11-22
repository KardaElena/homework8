// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



Console.Clear();

int[,] matrix = GetMatrix(4, 4);

PrintMatrix(matrix);
Console.WriteLine();



int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int start = 0;
    int i = 0;
    int j = 0;
    for (j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            start++;
            matrix[i, j] = start;
        }
    j = matrix.GetLength(0) - 1;
    for (i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            start++;
            matrix[i,j] = start;
        }
    i = matrix.GetLength(0) - 1;
    for (j = matrix.GetLength(1) - 1; j >=0; j--)
        {
            start++;
            matrix[i,j] = start;
        }
    j = 0;
    for (i = matrix.GetLength(0) - 2; i > 0; i--)
        {
            start++;
            matrix[i,j] = start;
        }
    
    matrix[1,1] = start + 1;
    matrix[1,2] = start + 2;
    matrix[2,2] = start + 3;
    matrix[2,1] = start + 4;

    
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6} ");
        }
        Console.WriteLine();
    }
}