/* Задача №2. Если набор данных - таблица

1, 2, 3
4, 6, 1
2, 1, 6

на выходе ожидаем получить

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] NewArray(int rows, int column)
{
    int[,] arr = new int[rows, column];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    return arr;
}

Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int column = int.Parse(Console.ReadLine()!);

int[] num = new int[9] { 1, 2, 3, 4, 6, 1, 2, 1, 6 };

int[] count = new int[9];

int[,] arr = NewArray(rows, column);

PrintArray(arr);

for (int i = 0; i < num.Length; i++)
{
    for (int s = 0; s < arr.GetLength(0); s++)
    {
        for (int r = 0; r < arr.GetLength(1); r++)
        {
            if (arr[s, r] == num[i])
                count[i]++;
        }
    }
}

for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine($" Число {num[i]} было в массиве {count[i]} раз ");
}