// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int k = 0; k < col; k++)
        {
            array[i, k] = new Random().Next(1, 10);
            Console.Write($"{array[i, k]} ");
        }
        Console.WriteLine();
    }
    return array;
}
double[] GetArifm(int[,] arr, int row, int col)
{
    double[] result = new double[col];

    for (int i = 0; i < row; i++)
    {
        for (int k = 0; k < col; k++)
        {
            result[k] += arr[i, k];

        }

    }
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Math.Round(result[i] / row, 2);
    }
    return result;
}

Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = GetArray(rows, columns);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца равно: \n{string.Join(" ", GetArifm(array, rows, columns))}");