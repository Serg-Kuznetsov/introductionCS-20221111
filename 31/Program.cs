// 31. Сгенерировать 10 случайных чисел и показать те, которые заканчиваются на четные цифры.
//Показать кубы чисел, заканчивающихся на четную цифру/
bool Test (int a)
{
  //if (a%2==0) return true; else return false;
  return a%2==0;
}

Random random=new Random();
for (int i=0;i<5;i++)
{
int a=random.Next(1,100);
int b=(int)Math.Pow(a,3);
if (Test (b))
System.Console.WriteLine($"{a}, {b}");
}



/*
int r=10;
double t=r; // Неявное приведение типов

int y=(int)x; // Явное приведение типов
*/