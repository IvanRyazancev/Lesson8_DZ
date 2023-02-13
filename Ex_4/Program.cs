// Задача №4. Найти произведение двух матриц.

Console.Write("Введите кол-во строк массива: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int columnA = int.Parse(Console.ReadLine()!);

Console.Write("Введите кол-во строк массива: ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int columnB = int.Parse(Console.ReadLine()!);

int[,] matrixA = new int[rowsA, columnA];
int[,] matrixB = new int[rowsB, columnB];


Console.WriteLine("Сформированная матрица A: ");

for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixA.GetLength(1); j++)
    {
        matrixA[i, j] = new Random().Next(1, 10);
        Console.Write($" {matrixA[i, j]} | ");
    }
    Console.WriteLine();
}

Console.WriteLine("Сформированная матрица B: ");

for (int i = 0; i < matrixB.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        matrixB[i, j] = new Random().Next(1, 10);
        Console.Write($"{matrixB[i, j]} | ");
    }
    Console.WriteLine();
}

Console.WriteLine("Результат умножения матриц A x B = C: ");

if (rowsA == rowsB && columnA == columnB)
{
    int rowsC = matrixA.GetLength(0);
    int columnC = matrixA.GetLength(1);
    int[,] matrixC = new int[rowsC, columnC];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            matrixC[i, j] = matrixA[i, j] * matrixB[i, j];
            Console.Write($" {matrixC[i, j]} | ");
        }
        Console.WriteLine();
    }    
}