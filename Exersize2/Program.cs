// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

int[,] array = GetArray(3, 4, 0, 9);
PrintArray(array);
Console.WriteLine("Write a index of row x: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write a index of column y: ");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("");

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

if (x<array.GetLength(0) && y<array.GetLength(1))
{
    Console.WriteLine($"{array[x,y]}");
}
else
{
    Console.WriteLine("This element doesnt exist");
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
