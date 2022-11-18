// Задача 47. Запросите от пользователя размерности двумерного массива.
 // Напишите метод для заполнения массива случайными числами. Напишите метод для вывода массива на экран 
 // (постарайтесь вывести массив красиво). Округлите значения, генерируемые Random до двух знаков после запятой.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Write("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] doubleArray = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        doubleArray[i, j] = new Random().NextDouble() * new Random().Next(1, 100);
        Console.Write("{0, 8}", Math.Round(doubleArray[i, j], 2));
    }
    Console.WriteLine();
}