// 70.	Показать натуральные числа от 1 до N, N задано


System.Console.WriteLine("Введите любое целое число");
int n = Convert.ToInt32(Console.ReadLine());

void Natural (int n, int i)
{
    if(i<=n)
    {
        System.Console.Write($"{i}  ");
        Natural(n,i+1);
    }

}
Natural(n,1);

