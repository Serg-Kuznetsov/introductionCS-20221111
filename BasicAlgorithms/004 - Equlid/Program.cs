// Алгоритм Евклидint a=10
int k=0;
int GCD(int a,int b)
{
while(a!=b)
{
    k++;
    if(a>b)
        a=a-b;
    else
         b=b-a;
 }
   return a;
}
 
    System.Console.WriteLine(GCD(15,60));
    System.Console.WriteLine(k);

int quikGCD(int a,int b)

    {
while(a!=0 && b!=0)
{
    k++;
    if(a>b)
        a=a%b;
    else
         b=b%a;
 }
   return a+b;
}

 System.Console.WriteLine(GCD(15,60));
 System.Console.WriteLine(k);
 k=0;
 System.Console.WriteLine(quikGCD(15,60));
 System.Console.WriteLine(k);
