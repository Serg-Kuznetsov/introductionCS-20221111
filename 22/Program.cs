// 22.	Программа проверяет пятизначное число на палиндромом.
System.Console.WriteLine("Введите трехзначное");
int a = Convert.ToInt32(Console.ReadLine());
int x1,x3;
x1=a/100; //1 цифра
x3=a % 10; // 3 цифра
if (x1==x3) System.Console.WriteLine("Является палиндромом");
else 
System.Console.WriteLine("НЕ является палиндромом");