// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinSumm(matrix) + 1}");



int MinSumm(int[,] matrix)
{
    int summ = 0;
    int minSumm = 0;
    int i = 0;
    int minI = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minSumm += matrix[i, j];
    }

    for (i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i, j];
        }
        if (summ < minSumm)
        {
            minSumm = summ;
            minI = i;
        }    
    }

return minI;
}


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