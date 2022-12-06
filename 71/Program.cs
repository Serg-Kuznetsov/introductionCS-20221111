// 71.	Показать натуральные числа от N до 1, N задано

System.Console.WriteLine("Введите любое целое число");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

void Natural (int n)
{
    if(n>0)

        {
        System.Console.Write($"{n}  ");
        Natural(n - 1);
        }

}
Natural(n);
