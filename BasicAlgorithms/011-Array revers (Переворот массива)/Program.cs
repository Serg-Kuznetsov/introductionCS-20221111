// Переводрот массива


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
 
void Swap (ref int a, ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void Revers(int[] a)
{ 
    int t;
    for (int i=0;i<a.Length/2;i++)
    {   
        t=a[i];
        a[i]=a[a.Length-1-i];
        a[a.Length-1-i]=t;
    }


    // Swap(ref a[i], ref a[a.Length-1-i]);
}

// Создали масив
int n=10;
int[]   a=RandomIntArray(n,0,200);
PrintArray(a,5);
// Обработка массива
Revers(a);
//a=a.Reverse().ToArray();
System.Console.WriteLine();
PrintArray(a,5);
