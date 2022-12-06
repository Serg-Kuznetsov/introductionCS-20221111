// 77.	Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
 //Первые два элемента последовательности 0 и 1 

System.Console.WriteLine("Задайте длинну массива");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[] a=new int[n];
a[0]=0;
a[1]=1;
for(int i=2;i<n;i++)
a[i]=a[i-1]+a[i-2];
for(int i=0;i<n;i++)
System.Console.Write($"{a[i]}  ");

