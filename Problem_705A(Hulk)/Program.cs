int n = int.Parse(Console.ReadLine());
string s = "I hate";

for (int i = 2; i <= n; i++)
{
    if (i % 2 == 0)
    {
        s += " that I love";
    }
    else
    {
        s += " that I hate";
    }
}

s += " it";
Console.WriteLine(s);