// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

System.Console.WriteLine("Введите текст");
string s=Console.ReadLine();
int count=0;
    for(int i=0; i<s.Length; i++)
    {
        if(s[i]=='a') count++;
    }

System.Console.WriteLine(count);




