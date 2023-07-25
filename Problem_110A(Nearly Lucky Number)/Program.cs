string s = Console.ReadLine();
int c = 0;
for(int i = 0; i < s.Length; i++)
{
    if (s[i] ==  '4' || s[i] == '7')
    { 
        c++;
    }
}
if (c == 4 || c == 7)
{
    Console.WriteLine("YES");
}
else
    Console.WriteLine("NO");