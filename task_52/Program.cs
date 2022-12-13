// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
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
double[] ArithMean(int[,] matr)
{
    double[] arithmean = new double[matr.GetLength(1)];

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        arithmean[j] = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            arithmean[j] = arithmean[j] + matr[i, j];
        }
     arithmean[j] = arithmean[j] /matr.GetLength(0) ; 
    }
    return arithmean;
}
void PrintArray(double[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}| ");
    }
    Console.WriteLine();
}
int rows = GetNumber("Введите количество строк");
int colums = GetNumber("Введите количество столбцов");
int[,] matrix = GetMatrix(rows, colums);
PrintMatrix(matrix);
ArithMean(matrix);
PrintArray(ArithMean(matrix));





