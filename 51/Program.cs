// 51.	С клавиатуры вводится число N. Затем вводятся N чисел. 
//Определить сколько чисел больше 0 введено с клавиатуры

System.Console.WriteLine("Задайте длинну массива");
int n=Convert.ToInt32(Console.ReadLine());

int[] a= new int[n];
for(int i=0;i<n;i++)
    {
     Console.WriteLine($"Введите элмент № {i+1}");
     a[i] = Convert.ToInt32(Console.ReadLine());
    }
int count=0;
for(int i=0;i<a.Length;i++) 
if (a[i]>0) count++; 

System.Console.WriteLine($"Количество эелементов больше нуля = {count}");


