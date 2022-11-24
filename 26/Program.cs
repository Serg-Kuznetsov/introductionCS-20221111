// 26.	Найти сумму чисел от 1 до А

System.Console.WriteLine("Введите любое целое число");
int a = Convert.ToInt32(Console.ReadLine());
int sum=0;
for(int i=0;i<a;i++)
sum=(a*(a+1))/2;
System.Console.WriteLine($"Сумма всех чисел от 1 до {a} = {sum}");

