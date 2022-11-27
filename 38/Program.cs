// 38.	В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] RandomIntArray (int size=123, int min=1, int max=2)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
    a[i]=random.Next(min,max);
    return a;
}

int CountOtrezok (int[] a)
{
    int s=0;
    for(int i=0;i<a.Length;i++)
    if (a[i]>=10 && a[i]<=99) s=s+1;
    return s;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
            System.Console.Write($"{a[i],5}");
}

int [] a=RandomIntArray(123,1,999);
Print (a);
System.Console.WriteLine();
System.Console.WriteLine($"Количество числе на отрезке 10-99: {CountOtrezok(a)}");
