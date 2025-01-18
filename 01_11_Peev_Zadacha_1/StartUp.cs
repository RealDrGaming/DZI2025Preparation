string word = Console.ReadLine();

List<string> words = new List<string>();

while (!string.IsNullOrEmpty(word))
{
    if (!words.Contains(word))
    {
        words.Add(word);
    }

    word = Console.ReadLine();
}

char[] vowels = ['A', 'E', 'I', 'O', 'U'];
bool isSinging = true;

List<string> singingWords = new List<string>();
List<string> quietWords = new List<string>();

foreach (string item in words)
{
    for (int i = 0; i < item.Length; i++)
    {
        if (i >= item.Length - 1)
            break;

        if (!vowels.Contains(item[i]) && !vowels.Contains(item[i + 1]))
        {
            isSinging = false;
            break;
        }
    }

    if (isSinging)
        singingWords.Add(item);
    else if (!isSinging)
        quietWords.Add(item);

    isSinging = true;
}

singingWords = singingWords.OrderBy(l => l).ToList();
quietWords = quietWords.OrderByDescending(l => l.Length).ThenBy(l => l).ToList();

foreach (string item in singingWords)
{
    Console.WriteLine(item);
}

foreach (string item in quietWords)
{
    Console.WriteLine(item);
}