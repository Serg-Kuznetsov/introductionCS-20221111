// 61.	Показать двумерный массив размером m×n заполненный вещественными случайными числами

double[,] a = new double[5, 5];

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        a[i, j] = random.NextDouble() * 100; 
        Console.Write("{0,6:F2}  ", a[i, j]);
    }
    Console.WriteLine();
}