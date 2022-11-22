// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = GetMatrix(rows, columns);

PrintMatrix(matrix);

int[,] sortedMatrix = SortDescend(matrix);

Console.WriteLine();

PrintMatrix(sortedMatrix);

int[,] GetMatrix(int r, int c)
{
    int[,] matrix = new int[r, c];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
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

int[,] SortDescend(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int max = matrix[i, 0];
        int maxj = 0;
        int temp = 0;
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max)
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[i, maxj];
                matrix[i, maxj] = temp;
            }
            
            if (matrix[i, j] > matrix[i, j - 1])
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[i, j - 1];
                matrix[i, j - 1] = matrix[i, j];
            }
        }
    }
    return matrix;
}

