int n = int.Parse(Console.ReadLine());
int c = 0;
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    if (s == "Tetrahedron")
    {
        c += 4;
    }
  
    else if (s == "Cube")
    {
        c += 6;
    }
    else if (s == "Octahedron")
    {
        c += 8;
    }
    else if (s == "Dodecahedron")
    {
        c += 12;
    }
    else if (s == "Icosahedron")
    {
        c += 20;
    }


}
Console.WriteLine(c);