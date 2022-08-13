// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] GetMatrix(int m, int n) //Создание рандомного двумерного массива, заполенного случайными числами
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

double[] GetAverageArithmetic(int[,] matrix) //Поиск среднего арифметического элементов в каждом столбце
{
    double[] averageColumnArray = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            averageColumnArray[j] += matrix[i, j];
            if (i == matrix.GetLength(0) - 1) averageColumnArray[j] /= matrix.GetLength(0);
        }
    }
    return averageColumnArray;
}

void PrintMatrix(int[,] array) //Печать двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array) //Печать массива
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(Math.Round(array[i], 1) + ", ");
        else Console.Write(Math.Round(array[i], 1) + "]");
    }
}

Console.Clear();

int[,] matrixResult = GetMatrix(3, 4);
PrintMatrix(matrixResult);

Console.WriteLine();

Console.WriteLine("Среднее арифметическое каждого столбца:");
double[] averageArithmetic = GetAverageArithmetic(matrixResult);
PrintArray(averageArithmetic);