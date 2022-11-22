// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int [,,] array = GetArray(2, 2, 2);
PrintArray(array);


int[,,] GetArray (int a, int b, int c)
{
    int[,,] array = new int[a, b, c];
    int start = new Random().Next(10, 20);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(0); l++)
            {
            array[i, j, l] = start + 10;
            start = array [i, j, l];
            }
        }
    }
return array;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(0); l++)
            {
                Console.Write($"{array[i,j,l], 5}({i},{j},{l}) ");
            }
        Console.WriteLine();
        }
        Console.WriteLine();
    }
}