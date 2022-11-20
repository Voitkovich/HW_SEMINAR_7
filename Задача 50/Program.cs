// Задача 50. Напишите программу, которая будет принимать от пользователя позицию (M, N)
 // двумерного массива и возвращать значение элемента, стоящего в этой позиции. 
 // Если такой позиции в массиве нет, то сообщить об этом пользователю. 
 // Сгенерировать массив случайным образом. Размерность массива определить самостоятельно. 
// Использование методов для заполнения массива обязательно. Остальное можно реализовать в главной программе.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции.
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

Console.Write("Введите М: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

        if(M < array.GetLength(0) && N < array.GetLength(1) )
        {
            Console.Write( $"{array[M, N]}");
        }
       else
        {
            Console.WriteLine("Элемент отсутствует");
        }
        Console.WriteLine();

