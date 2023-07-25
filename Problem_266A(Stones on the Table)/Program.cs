int a = int.Parse(Console.ReadLine());
string s = Console.ReadLine();
int c = 0;
for (int i = 1; i < a; i++)
{
    if(s[i] == s[i - 1])
    {
        c++;
    }
    
}
Console.WriteLine(c);

