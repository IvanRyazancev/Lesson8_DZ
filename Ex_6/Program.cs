// Задача №6. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента.

int[,,] CreateMatrix (int row, int col, int dep, int min, int max) 
{
    int[,,] matrix = new int[row, col, dep];
    Random rnd = new Random();   
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i,j,k] = rnd.Next(min, max + 1);
                }
        }
    }
    return matrix;
} 
 
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($"{matrix[i, j, k], 1} ({i},{j},{k})|");            
            }
        }
        Console.WriteLine();        
    }        
}
 
Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int column = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во 3D стобцов массива: ");
int z = int.Parse(Console.ReadLine()!);

int[,,] array3D = CreateMatrix(rows, column, z, 10, 99);
PrintMatrix(array3D);