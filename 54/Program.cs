﻿// 54.	С клавиатуры вводится число N. Показать первые N чисел Фибоначчи.
// Принять первые числа равными 0 и 1

System.Console.WriteLine("Задайте длинну массива");
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[] a=new int[n];
a[0]=0;
a[1]=1;
for(int i=2;i<n;i++)
a[i]=a[i-1]+a[i-2];
for(int i=0;i<n;i++)
System.Console.WriteLine($"{a[i]}");

