// 15.	С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

System.Console.WriteLine("Введите целое число число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a<99) System.Console.WriteLine("NO");
if (a>99) System.Console.WriteLine(a%10%10);
if (a>999) System.Console.WriteLine("Данная программа не поддерживает четырехзначные числа :)");


