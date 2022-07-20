// Задайте двумерный массив
// Написать программу, принимающая на вход позиции элемента в двумерном массиве, и возвращающее
// значение этого элемента, или указание что такого элемента нет

Console.WriteLine("Введите кол-во M Строк");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во N Столбцов");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию строки (i)");
int i0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца (j)");
int j0 = Convert.ToInt32(Console.ReadLine());

int[,] array = new int [M,N];

Random rnd = new Random();

for (int i = 0; i < M; i++) // Заполнение двумерного массива случайными числами
{
    for (int j = 0; j < N; j++)
    {
        array[i, j] = rnd.Next(-10, 10);
        Console.Write(array[i, j]+ "    ");        
    }
    Console.WriteLine();
}

if (i0 >= M || i0 >= N || i0 < 0 || j0 < 0)
{
    Console.WriteLine("Нет такого элемента, так как значения выходят за предел массива");
}
else
{
    Console.WriteLine("Элемент двумерного массива с i=i0 и j=j0 = {0}", array[i0, j0]);
}


