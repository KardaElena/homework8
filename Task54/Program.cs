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
for (int j = 0; j < matrix.GetLength(1); j++)
{

        for (int k = 0; k < matrix.GetLength(1)-1; k++)
            if (matrix[i, k] < matrix[i, k+1])
            {
                int max = matrix[i, k+1];
                matrix[i, k+1] = matrix[i, k];
                matrix[i, k] = max;

            }
    }
}
return matrix;
}
