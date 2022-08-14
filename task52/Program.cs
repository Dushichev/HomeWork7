/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/



Console.WriteLine("введите количество строк двумерного массива");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("введите количество столбцов двумерного массива");
int columns = int.Parse(Console.ReadLine());

int[,] array = new int[row, columns];

Random random = new Random();


for (int i = 0; i < array.GetLength(0); i++)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(0, 10);

        Console.Write(array[i, j] + "\t");

    }
    Console.WriteLine();
}

double[] res = new double[columns];

for (int i = 0; i < array.GetLength(1); i++)
{


    for (int j = 0; j < array.GetLength(0); j++)
    {

        res[i] += array[j, i];

    }
    Console.WriteLine();
    Console.Write($"сумма элементов столбца номер {(i + 1)} = " + res[i] + "\t");
    Console.WriteLine();
    Console.Write("среднеарифметическое столбца  = ");
    Console.WriteLine(res[i] = Math.Round((res[i] / (double)row), 1));
}





