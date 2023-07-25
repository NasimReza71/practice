int x = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
        if (s[1] == '+' )
    {
        x++;
        
    }
    else
    {
        x--;
    }
   
}
Console.WriteLine(x);