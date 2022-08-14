/*Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17->такого числа в массиве нет*/

Console.WriteLine("введите количество строк и столбцов через запятую");
string[] input = Console.ReadLine().Split(",");
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);
int[,] array = new int[row, col];
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

Console.WriteLine("введите индексы позиции эллемента через запятую");
string[] pos = Console.ReadLine().Split(",");
int a = int.Parse(pos[0]);
int b = int.Parse(pos[1]);
int count = 0;
if (a > count && b > count)
{
    Console.WriteLine("числа с данными координатами нет");
}
for (int i = 0; i < array.GetLength(0); i++)
{
    count++;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (a == i && b == j)

        {
            Console.WriteLine(array[a, b]);

        }
    }

}


