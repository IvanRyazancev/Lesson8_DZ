// Задача №5. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.Write("Введите количество строк матрицы: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк матрицы: ");
int column = int.Parse(Console.ReadLine()!);

int[,] array = new int[rows, column];

Console.WriteLine("Сформированная матрица: ");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < column; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($" | {array[i, j]} | ");
    }
    Console.WriteLine();
}

Console.WriteLine($"Минимальные числа в строках матрицы и их индексы: ");

int[,] newarray = new int[rows - 1, column - 1];

int min = array[0, 0];
int indexi = 0;
int indexj = 0;
for (int i = 0; i < array.GetLength(0); i++)
{       
    for (int j = 0; j < array.GetLength(1); j++)
    {        
        if (min > array[i, j])
        {
            min = array[i, j];
            indexi = i;
            indexj = j;
        }         
    }    
}
Console.Write($" | {min}");
Console.WriteLine($" [{indexi}, {indexj}] | ");

Console.WriteLine($"Преобразованный массив: ");

int i1 = 0;
int j1 = 0;
for (int i = 0; i < newarray.GetLength(0); i++)
{    
    if (i >= indexi)
    {
        i1 = i + 1;
    }
    else
    {
        i1 = i;
    }
    for (int j = 0; j < newarray.GetLength(1); j++)
    {   
        if (j >= indexj)
        {
            j1 = j + 1;
        }     
        else
        {
            j1 = j;
        }
        newarray[i, j] = array[i1, j1];
        Console.Write($" | {newarray[i, j]} | ");
    }
    Console.WriteLine();
}