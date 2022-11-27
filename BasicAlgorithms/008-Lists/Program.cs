// Расчитать среднюю темпрературу
// Списки

List<int> temp;
temp=new List<int>();// Можно указать количество элементов, чтоб ускорить работу программы
// temp.Add(10); - добавить элемент
for (int i=0; i<7;i++)
    temp.Add(Convert.ToInt32(Console.ReadLine()));
    double s=0;
for (int i=0; i<7;i++)
    s=s+temp[i];
System.Console.WriteLine(s/temp.Count);

