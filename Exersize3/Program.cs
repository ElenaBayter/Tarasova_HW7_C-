// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = GetArray(5, 3, 0, 10);
PrintArray(array);
Console.WriteLine("");
double AV = Average(5, array);
Console.WriteLine(AV);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}
double Average(int m, int [,] array)
{
    double sum = 0;
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++) 
    { 
        for (int i = 0; i < array.GetLength(0); i++) 
        { 
            sum += (double)array[i, j]; 
        }
        result = sum/m;
        Console.Write($"{Math.Round(result, 2)} ");
        sum = 0;
    }
    return result;
}
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
