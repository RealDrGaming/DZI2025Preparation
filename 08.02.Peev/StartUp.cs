using _08._02.Peev;

List<Churchman> arr = new List<Churchman>();

string f = "catholic.txt";
try
{
    StreamReader sr = new StreamReader(f);
    string[] v;
    string s;
    s = sr.ReadLine();
    while (s != null)
    {
        v = s.Split(',');
        switch (v[1].ToLower())
        {
            case "pope": arr.Add(new Pope(v[0])); break;
            case "cardinal": arr.Add(new Cardinal(v[0], v[2])); break;
            case "archbishop": arr.Add(new Archbishop(v[0], v[2])); break;
            case "bishop": arr.Add(new Bishop(v[0], v[2])); break;
            case "priest": arr.Add(new Priest(v[0], v[2])); break;
        }
        s = sr.ReadLine();
    }
    sr.Close();
    Console.Write("Input name: ");
    string n = Console.ReadLine();
    ShowSubordin(n);
}
catch (Exception)
{
    Console.WriteLine("File not found");
}

void ShowSubordin(string name)
{
    foreach (Churchman c in arr)
    {
        if (c.GetSuperiorName() == name)
        {
            Console.WriteLine(c);
            ShowSubordin(c.PersonName);
        }
    }
}