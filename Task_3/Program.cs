// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 15);

        Console.Write($"{array[i, j]} ");

    }
    Console.WriteLine();
}
Console.WriteLine();
for (int j = 0; j < array.GetLength(1); j++)
{
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result = (result + array[i, j]);
    }
    result = Math.Round(result / n, 2);
    Console.Write($"[{(result)}] ");
}
Console.WriteLine();