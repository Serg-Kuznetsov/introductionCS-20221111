// Сортировка выбором


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


void SeleectSort (int[] a, out int count)
{   
    count=0;
    int im;
    for(int i=0;i<a.Length;i++)
    {
    im=i;
    for(int j=i+1;j<a.Length;j++)
        {
             if(a[im]<a[j]) im=j;
            count++;
        }
        Swap(ref a[i], ref  a[im]);
    }
}

int[]   a=RandomIntArray(10,0,10);
PrintArray(a);
int count=0;
SeleectSort(a, out count);
System.Console.WriteLine();
PrintArray(a);
System.Console.WriteLine();
System.Console.WriteLine(count);