// 29.	Подсчитать сумму цифр в числе

System.Console.WriteLine("Введите любое целое число");
int a = Convert.ToInt32(Console.ReadLine());
int sum=0;
while (a>0)
{
sum = sum+a%10;
a=a/10;
}
System.Console.WriteLine(sum);