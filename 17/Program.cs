//17.	Дано число обозначающее день недели. Выяснить является номер дня недели выходным

System.Console.WriteLine("Введите число от 1 до 7");
int a = Convert.ToInt32(Console.ReadLine());
if (a>=1 && a<=5) System.Console.WriteLine("Рабочий день");
else
System.Console.WriteLine("Выходной!");
