// Расчитать температуру за неделю

/*
int t1,t2,t3,t4,t5;
double s=0;
t1=Convert.ToInt32(Console.ReadLine());
t2=Convert.ToInt32(Console.ReadLine());
t3=Convert.ToInt32(Console.ReadLine());
t4=Convert.ToInt32(Console.ReadLine());
t5=Convert.ToInt32(Console.ReadLine());
s=(t1+t2+t3+t4+t5)/7;
System.Console.WriteLine(s);
*/

// Массивы - это объекты
int N=7;
int [] t; // если так описать, то он пустой, неприсвоенно (null)
t=new int[N]; // создаем массив, т.е. в t  помещаем адрес массива
double s=0;
// заполнить массив
for (int i=0; i<t.Length;i++)
    t[i]=Convert.ToInt32(Console.ReadLine());
// обработать массив
for (int i=0;i<t.Length;i++)
    s=s+t[i];
// вывод результата
    System.Console.WriteLine(s/t.Length);