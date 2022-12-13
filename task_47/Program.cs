// Задача 47. Задайте двумерный массив размером m×n, заполненный 
//случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9
//Random rand = new Random();             // Генерится случайное вещественное число
// Console.WriteLine(rand.NextDouble());   // в диапазоне от [0.0 до 1.0)
//Console.WriteLine(rand.NextDouble()*10-10);   // в диапазоне от [-5.0 до 5.0)
//Console.WriteLine($"{rand.NextDouble() * 10 - 10:f2}");   // в диапазоне от [-5.0 до 5.0) 2 значащие цифры.

double[,] GetMatrix(int rowsCount, int columnsCount, double leftRange = -1.25, double rightRange = 11.75) 
{
    double[,] matr = new double[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            matr[i, j] = rand.NextDouble()*(rightRange-leftRange)+leftRange;

        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //GetLength(0) для строк 0, метод.
    {
        for (int j = 0; j < matr.GetLength(1); j++) //GetLength(0) для столбцов 1, метод.
        {
            Console.Write($"{matr[i, j] + "|"}");
        }
        Console.WriteLine(); //чтобы печаталось новая строка с новой строки.
    }
}

int rows = GetNumber("Введите число строк");
int colums = GetNumber("Введите число столбцов");
double[,] matrix = GetMatrix(rows, colums);
PrintMatrix(matrix);

