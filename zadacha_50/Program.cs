// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int k = 0; k < col; k++)
        {
            array[i, k] = new Random().Next(0, 10);
            Console.Write($"{array[i, k]} ");
        }
        Console.WriteLine();
    }
    return array;
}

void GetPos(int[,] arr, int arr_row, int arr_col, int search_row, int search_col)
{
    if (search_row > arr_row && search_row < 0 | search_col > arr_col && search_col < 0)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"искомый элемент: {arr[search_row, search_col]}");
    }
}
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите строку в массиве: ");
int searh_row = int.Parse(Console.ReadLine());
Console.Write("Введите столбец в массиве: ");
int search_col = int.Parse(Console.ReadLine());


int[,] array = GetArray(rows, columns);
GetPos(array, rows, columns, searh_row, search_col);