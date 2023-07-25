string  s  =  Console.ReadLine();
for (int i = 0; i < s.Length; i++)
{
    if (i + 2 < s.Length && s[i] == 'W' && s[i+1] == 'U' && s[i+2] == 'B')
    {
        i = i + 2;
        Console.Write(" ");
    }
    else
    {
        Console.Write(s[i]);
    }
}