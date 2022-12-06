// Сумма цифр
int Sumdigit (int n)
{
    if(n==0) return 0;
    else
        return Sumdigit(n/10)+n%10;
}

System.Console.WriteLine(Sumdigit(123));
// using System;
// int n=int.Parse(Console.ReadLine());
// System.Console.WriteLine(n/100);