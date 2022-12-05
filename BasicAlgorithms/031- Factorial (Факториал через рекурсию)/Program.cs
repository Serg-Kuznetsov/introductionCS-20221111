// Факториал через рекурсию
int f(int n)
{
    if (n==0) return 1;
    else
        return f(n-1)*n;
}
System.Console.WriteLine(f(5));