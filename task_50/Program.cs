// ​Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​Например, задан массив:
// ​1 4 7 2
// ​5 9 2 3
// 8 4 2 4
// ​1 7 -> такого числа в массиве нет

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 50)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange);

        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "|");
        }
        Console.WriteLine();
    }
}
void GetElement(int[,] matr, int row, int column)
{
    if (row>0 && row < matr.GetLength(0) + 1 && column>0 && column < matr.GetLength(1) + 1)
    {
        Console.WriteLine(matr[row - 1, column - 1]);
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}

int rows = GetNumber("Введите количество строк");
int colums = GetNumber("Введите количество столбцов");
int row = GetNumber("Введите номер строки");
int column = GetNumber("Введите номер столбца");

int[,] matrix = GetMatrix(rows, colums);
PrintMatrix(matrix);
GetElement(matrix, row, column);

