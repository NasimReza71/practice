string a = Console.ReadLine(), b = Console.ReadLine(), c = Console.ReadLine(), s;

s = a + b; 
char[] s_char = s.ToCharArray();
Array.Sort(s_char);
s = new string(s_char);

char[] c_char = c.ToCharArray();
Array.Sort(c_char);
c = new string(c_char);

if ( s == c)
{
    Console.WriteLine("YES");
}
else
    Console.WriteLine("NO");