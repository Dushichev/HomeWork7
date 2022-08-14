/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

Console.WriteLine("введите количество строк двумерного массива");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("введите количество столбцов двумерного массива");
int columns = int.Parse(Console.ReadLine());

double[,] array = new double[row, columns];

Random rnd = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {

        array[i, j] = rnd.Next(-30, 30) / (double)10;

        Console.Write(array[i, j] + "\t");

    }

    Console.WriteLine();
}

