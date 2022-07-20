// Задайте двумерный массив
// Заполненный случайными вещественными числами

Console.WriteLine("Введите кол-во M Строк");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во N Столбцов");
int N = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [M,N];

Random rnd = new Random();

for (int i = 0; i < M; i++) // Заполнение двумерного массива случайными числами
{
    for (int j = 0; j < N; j++)
    {
        array[i, j] = rnd.Next(0, 100) / 10.0; // Генерация Рандом с дробной частью
        Console.Write(array[i, j]+ " ");  
    }
    Console.WriteLine();
}
