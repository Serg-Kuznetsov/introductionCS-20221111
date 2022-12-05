// Цикл с помощью рекурсии
// Вывести числа от 1 до N ббез использования цикла

void Loop(int n, int i)
{
    if(i<=n)
    {
        System.Console.WriteLine(i);
        Loop(n,i+1);
    }

}
Loop(10,1);
