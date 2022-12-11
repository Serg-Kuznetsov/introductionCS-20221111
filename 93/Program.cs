// Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

void PrintArray(int [,] a)
{
    for (int i=0;i<a.GetLength(0);i++)
        {
    for (int j=0;j<a.GetLength(1);j++) 
    System.Console.Write($"{a[i,j],3}");  
        System.Console.WriteLine();
        }
}

int[,] RandomArray1(int n, int m, int min=0, int max=10)
{
int[,] a=new int[n,m];
Random random=new Random();
for (int i=0;i<n;i++)
    for (int j=0;j<m;j++)
    a[i,j]=random.Next(min,max+1);
    return a;
}

int[,] RandomArray2(int n, int m, int min=0, int max=10)
{
int[,] a=new int[n,m];
Random random=new Random();
for (int i=0;i<n;i++)
    for (int j=0;j<m;j++)
    a[i,j]=random.Next(min,max+1);
    return a;
}

System.Console.WriteLine("  Матрица №1:");
int [,] m1=RandomArray1(3,3);
PrintArray (m1);

System.Console.WriteLine();

System.Console.WriteLine("  Матрица №2:");
int [,] m2=RandomArray2(3,3);
PrintArray (m2);

System.Console.WriteLine();

System.Console.WriteLine("  Произведение дву матриц:");
int [,] m3=Proizvedenie(3,3);
PrintArray (m3);

int[,] Proizvedenie (int n, int m, int min=0, int max=100)
{
int[,] a=new int[n,m];
for (int i=0;i<n;i++)
    for (int j=0;j<m;j++)
    a[i,j]=m1[i,j]*m2[i,j];
    return a;
}

