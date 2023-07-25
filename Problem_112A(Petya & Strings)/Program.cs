string a = Console.ReadLine();
string b = Console.ReadLine();
a = a.ToLower();
b = b.ToLower();

if (a == b)
    Console.WriteLine("0");
else
{
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] < b[i])
        {
            Console.WriteLine("-1");
            break;
        }
        if (a[i] > b[i])
        {
            Console.WriteLine("1");
            break;
        }
    }
}