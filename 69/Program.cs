// 69.	Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива
int[]   RandomIntArray(int n, int min, int max)
{
int[]  a=new int[n];

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


void BubbleSort (int[] a)
{   
int flag=0;
    for (int i=0;i<a.Length;i++)
    {
        flag=0;
        for (int j=0;j<a.Length-1-i;j++)
        {
            if(a[j]<a[j+1]) 
                Swap(ref a[j], ref a[j+1]);
                flag=1;
        }
        if (flag==0) return;
    }
}

int[]   a=RandomIntArray(10,0,10);
PrintArray(a);
BubbleSort(a);
System.Console.WriteLine();
PrintArray(a);
