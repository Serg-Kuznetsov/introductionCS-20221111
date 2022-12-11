// 89. Подсчитать сумму цифр, встречающихся в строке

// string s="12345";
// int sum=s.Cast<int>().Sum();
// System.Console.WriteLine(sum);

// Делегаты
// int CountDigits (string s)
// {
//     int count=0;
//     foreach(char c in s)
//     if (char.IsDigit(c))
//     count++;
//     return count;
// }

// int CountDLatin(string s)
// {
//     int count=0;
//     foreach(char c in s)
//     if (c>='A' && c<='Z'|| c>='a' && c<='z')
//         count++;
//     return count;
// }
using System.Linq;

delegate bool IsChar(char c); // сигнатура bool(char)

class Program
{
static int CountChars(string s, IsChar IsChar)
    {
        int count=0;
        foreach(char c in s)
        if (IsChar(c))
            count++;
        return count;
    }

    static bool IsLatin(char c)
    {
        return (c>='A' && c<='Z'|| c>='a' && c<='z');
    }
static void Main()
{
    // Action click;
    // click=new Action(Выделение);
    // click=new Action(Заливка);

    string s="Эта строка содержит latinskie буквы и цифры (12345)";
    System.Console.WriteLine(CountChars(s,IsLatin));
    
}
}
