﻿// С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго (блок-схема)
System.Console.WriteLine("Введите число а:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b:");
double b=Convert.ToDouble(Console.ReadLine());

/*
// Полное условие
if ()
{
// True
}

else
{
// False
}

// Не полное условие
if()    
{
    //True
}
*/

if (a*a==b)
{
     System.Console.WriteLine($"{b} является квадратом {a}"); 
}
if (b*b==a)
 {
    System.Console.WriteLine($"{a} является квадратом {b}");
 }