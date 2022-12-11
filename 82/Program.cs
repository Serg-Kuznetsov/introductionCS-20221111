// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки.

System.Console.WriteLine("Введите строку содержащую точку");
string s=Console.ReadLine();
int count = s.IndexOf('.');

System.Console.WriteLine(count);


