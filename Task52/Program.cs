// Задайте двумерный массив из целых чисел
// Найдите среднее арифметическое элементов к важдом столбце


Console.WriteLine("Введите кол-во M Строк");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во N Столбцов");
int N = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [M,N];

Random rnd = new Random();

for (int i = 0; i < M; i++) 
{
    for (int j = 0; j < N; j++)
    {
        array[i, j] = rnd.Next(0, 10);
        
        Console.Write(array[i, j]+ "  ");  
    }
    Console.WriteLine();
}

for (int j = 0; j < N; j++)
{
    double sumSrAr = 0;
    int j0 = 0;
    for (int i = 0; i < M; i++)
    {
        sumSrAr += array[i, j];
    }
    Console.WriteLine("Средн. Арифм. элементов {0}-го столбца = {1}",j+1 ,sumSrAr/M);
}
