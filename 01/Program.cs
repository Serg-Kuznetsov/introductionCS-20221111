
#region CW Hello, World
/*
Console.WriteLine("Hello, World!");

Console.WriteLine("2+2");

System.Console.WriteLine("adawdad"+"asdadas"+2+"Asdasda"); // Метод
*/
#endregion

#region Типы данных
/* int a=0, b=0, c=0; // целый
int переменная1=0; // можно писать переменные на русском языке. Переменная не может быть названа с цифры и содержать символы


float f=20.4f; // 32 бит
double d=3.14; // вещественный. 64 бит
string s="asdads";
char c0='a';
bool flag=true;
*/
#endregion


// С клавиатуры вводится целое число. Вывести квадрат числа (блок-схема)

int a; // 32 бит, от - 2 млрд до + 2 млрд
a=10;
System.Console.WriteLine("Введите число");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a*a;
System.Console.WriteLine(Convert.ToString(a)+"^2="+b.ToString()); 
System.Console.WriteLine("{0}^2={1}",a,b); // Старый способ (интерполяция)
System.Console.WriteLine($"{a}^2={b}"); // Новый способ (интерполяция)