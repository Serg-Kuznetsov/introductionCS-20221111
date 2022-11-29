// 46. (38)	В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


int[]   RandomIntArray(int n, int min, int max)
{
int[]  a=new int[n];
// Заполнили массив
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i] =random.Next(0,200);
    return a;

}

void PrintArray (int[]  a, int tab=5)
{
for(int i=0;i<a.Length;i++) 
    System.Console.Write("{0,"+tab+"}",a[i]); 
}
 
int Solve  (int[] a)
{
// foreach
int count=0;
 foreach (int el in a)
    if(el>=10 && el<=99)
        count++;
        return count;

}

// Создали масив
int n=5;
int[]   a=RandomIntArray(n,0,200);
PrintArray(a,12);
System.Console.WriteLine($"\n{Solve(a)}");
