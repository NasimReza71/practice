string s = Console.ReadLine();
string t  = Console.ReadLine();

string r = new string(t.Reverse().ToArray());

if(r == s)
{
    Console.WriteLine("YES");
}
else
    Console.WriteLine("NO");