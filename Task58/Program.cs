// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// 1. Создать новую матрицу с числом строк 1-й матрицы и числом столбцов 2-й матрицы. 
// 2. Умножить первый элемент первой строки первой матрицы на 1-й элемент первого столбца второй матрицы, второй - на второй и т.п. 
// 3. Сложить полученные цифры и записать результат в первый элемент новой матрицы



Console.Clear();

int[,] matrix1 = GetMatrix(2, 2);
int[,] matrix2 = GetMatrix(2, 2);

PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
int[,] matrix3 = MatrixComposition(matrix1, matrix2);
Console.WriteLine();
PrintMatrix(matrix3);

int[,] MatrixComposition(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                for (int a = 0; a < matrix1.GetLength(1); a++)
                {
                    matrix3[i, j] += matrix1[i, a] * matrix2[a, j];
                }
            }
        }
    }
    return matrix3;
}


int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
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