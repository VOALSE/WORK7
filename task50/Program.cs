// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет. Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

Console.Clear();

Console.WriteLine("Для поиска числа в двумерном массиве введите данные.");
Console.Write("Введите номер строки: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());


int[,] GetMatrix(int m, int n) //Создание рандомного двумерного массива, заполенного случайными числами
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}

int SearchNumber(int[,] matrix, int m, int n) //Поиск числа в двумерном массиве
{
    int result = -1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == m - 1 && j == n - 1) result = matrix[i, j]; // Вычитаем 1 для чтения таблицы по "Человечески"
        }
    }
    return result;
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

Console.Clear();

int[,] matrixResult = GetMatrix(3, 4);
PrintMatrix(matrixResult);

Console.WriteLine();
int getNumber = SearchNumber(matrixResult, line, column);
if (getNumber > 0) Console.WriteLine($"Число из {line} строки и {column} столбца -> {getNumber}");
else Console.WriteLine($"Числа из {line} строки и {column} столбца в массиве нет");