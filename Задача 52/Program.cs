// Задача 52. Запросите от пользователя размерности двумерного массива. 
// Напишите метод для заполнения массива случайными числами.
// Напишите метод для поиска ср. арифметического значения каждого столбца.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void arithmeticMean(int[,]array)

{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[j, i];
        }
        Console.WriteLine();
        Console.WriteLine(sum / array.GetLength(1));
        sum = 0;
    }
}

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
Console.Write("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

fillArray(array);
Console.WriteLine(array);
arithmeticMean(array);
Console.WriteLine(array);