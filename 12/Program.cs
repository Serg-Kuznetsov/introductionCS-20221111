// 12.	С клавиатуры вводится целое число из диапазона 10, 99].Показать наибольшую цифру числа/

int n;
do
{
System.Console.WriteLine("Введите число от 10 до 99");
n=Convert.ToInt32(Console.ReadLine());
}
while (n<10 || n>99);

int a=n/10;
int b=n%10;
int max;
if (a>b) max=a;
else max=b;

System.Console.WriteLine($"Max = {max}");

 


