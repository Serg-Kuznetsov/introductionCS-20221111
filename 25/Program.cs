// 25.	Вывести на экран кубы чисел от 1 до N

System.Console.WriteLine("Введите любое целое число");
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n;i++)
System.Console.WriteLine($"{i} в кубе = {i*i*i}");
