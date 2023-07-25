int n  = int.Parse(Console.ReadLine());
string s  = Console.ReadLine();
int c1 = 0, c2=0;
for (int i = 0; i < n; i++)
{
    if (s[i] == 'A')
    {
        c1++;
    }
    else if (s[i] == 'D') 
    {
        c2++;
    }

}
if (c1>c2)
{
    Console.WriteLine("Anton");
}
else if (c2>c1)
{
    Console.WriteLine("Danik");
}
else if(c1 == c2)
{
    Console.WriteLine("Friendship");
}

