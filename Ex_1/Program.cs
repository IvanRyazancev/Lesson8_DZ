/* Задача №1. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Пример: Есть набор данных

{ 1, 9, 9, 0, 2, 8, 0, 9 }

частотный массив может быть представлен так:

0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
*/

Console.Write("Введите количество элементов последовательности: ");
int n = int.Parse(Console.ReadLine()!);

void FillArray(int[] collection)

{
    int length = n;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int count = n;
    int position = 0;
    Console.WriteLine("Исходный массив: ");
    while (position < count)
    {        
        Console.Write($" " + collection[position] + " ");
        position++;
    }
}

int[] array = new int[n];

FillArray(array);
PrintArray(array);
Console.WriteLine();


for (int i = 0; i <= array.Length - 1; i++)
{        
    int count = 0;    
    for (int j = 0; j < array.Length; j++)
    {    
        if (array[i] == array[j])
        {
            count++;            
        }    
    } 
    Console.WriteLine($"Число  {array[i]} встречается  {count} раз ");    
}