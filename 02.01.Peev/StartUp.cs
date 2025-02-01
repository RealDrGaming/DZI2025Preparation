int n = int.Parse(Console.ReadLine());

List<string> list = new List<string>();

for (int i = 0; i < n; i++)
{
    list.Add(Console.ReadLine());
}

string wordToSearch = Console.ReadLine();
string wordToSearchReverse = Reverse(wordToSearch);
bool atLeastOneWordContains = false;

foreach (string s in list)
{
	if (s.Replace(" ", "").Contains(wordToSearch) || s.Replace(" ", "").Contains(wordToSearchReverse))
	{
        Console.WriteLine(s);
        atLeastOneWordContains = true;
    }
}

if (!atLeastOneWordContains)
    Console.WriteLine("no");

string Reverse(string text)
{
    char[] array = text.ToCharArray();
    Array.Reverse(array);
    return new String(array);
}