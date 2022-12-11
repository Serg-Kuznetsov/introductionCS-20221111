// ABC=>CBA


bool Test (string s1, string s2)
{
    s1=s1.ToLower();
    s2=s2.ToLower();
    if(s1.Length!=s2.Length) return false;

    char[] c1=s1.ToCharArray();
    char[] c2=s2.ToCharArray();
    Array.Sort(c1); //ABC
    Array.Sort(c2); //ABC
    s1=new string (c1);
    s2= new string (c2);

    return s1==s2;


}
string s1="ABCDEr";
string s2="REDBCA";
System.Console.WriteLine(Test(s1,s2));


