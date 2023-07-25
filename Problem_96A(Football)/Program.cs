string s = Console.ReadLine();  
int t  = 0, a = 0, b = 0;
for (int i = 0; i < s.Length; i++)
{
    if (s[i] ==  '1')
    {
        a++;
        b = 0;
    }
    else
    {
        b++;
        a = 0;
    }
    if(a == 7 || b == 7)
    {
        t = 1;
        break;
    }
}

if (t == 1)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
