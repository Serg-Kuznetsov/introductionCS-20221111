// 61.	Показать двумерный массив размером m×n заполненный вещественными случайными числами



double [,] Random2dArray(double n, double m, double min=0, double max=10)
{
double [,] a=new idouble[n,m];
Random random=new Random();
for (int i=0;i<n;i++)
    for (int j=0;j<m;j++)
    a[i,j]=random.Next(min,max+1);
    return a;
}
void Prdouble2DArray(double [,] a)
{
    for (int i=0;i<a.GetLength(0);i++)
        {
    for (int j=0;j<a.GetLength(1);j++) 
    System.Console.Write($"{a[i,j], 4}");  
        System.Console.WriteLine();
        }
}


int [,] a=Random2dArray(7,7);
Prdouble2DArray(a);

