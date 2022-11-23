// 28.	Определить количество цифр в числе. Сделать подпрограмму.

int CountDigits(int number)
// Подпрограмма
{
    number = Math.Abs(number);
    int count=0;
    if (number==0) count=1;
    while (number>0)
    {
        number=number/10;
        count++;
    }
    return count;
}

// Основная программа
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CountDigits(N));