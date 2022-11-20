// Задача 52. Запросите от пользователя размерности двумерного массива. 
// Напишите метод для заполнения массива случайными числами.
// Напишите метод для поиска ср. арифметического значения каждого столбца.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void fillArray(int[,] array )

{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 100);
        Console.Write("{0, 4}", array[i, j] + "\t");
    }
    Console.WriteLine();
}
}
int m = 10;
int n = 10;
int[,] array = new int[m, n];

fillArray(array);
Console.WriteLine(array);