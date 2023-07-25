string s1 = Console.ReadLine();
string s2 = Console.ReadLine();
char[] array = s1.ToCharArray();  
for (int i = 0; i < array.Length; i++)
{
    if (s1[i] == s2[i])
    {
        array[i] = '0';
    }
    else
    {
        array[i] = '1';
    }
}

string  r = new string(array);
Console.WriteLine(r);
