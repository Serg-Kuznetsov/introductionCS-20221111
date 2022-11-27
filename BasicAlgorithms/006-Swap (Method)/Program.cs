// See https://aka.ms/new-console-template for more information



void Swap(ref int a,ref int b) // reference - ccakrf
{
int t=a;
a=b;
b=t;
}

void Calculator(int a, int b, out int sum, out int multi)

{
    sum=a+b;
    multi=a*b; 
}

int a=3,b=5;

System.Console.WriteLine($"a={a} b={b}");
Swap(ref a,ref b);
System.Console.WriteLine($"a={a} b={b}");

int sum,multi;
Calculator(a,b,out sum,out multi);

bool flag;
int x;

do
{
    flag=int.TryParse(Console.ReadLine(),out x);
}
while (flag==false);
if(flag==false) System.Console.WriteLine("Введите целое число");
int.TryParse("423234", out x);
