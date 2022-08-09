// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArray(int row, int col)
{
    double[,] result = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int k = 0; k < col; k++)
        {

            result[i, k] = Math.Round(new Random().NextDouble() * 10, 2) *
            ((new Random().Next(0, 2) == 0) ? 1 : -1);

            Console.Write($"{result[i, k]}  ");

        }
        Console.WriteLine();
    }
    return result;
}
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();
GetArray(rows, columns);