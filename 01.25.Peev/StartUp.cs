using _01._25.Peev;

int n = int.Parse(Console.ReadLine());
List<Instrument> instruments = new List<Instrument>();

for (int i = 0; i < n; i++)
{
    string[] lineArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string type = lineArgs[0].ToLower();
    string instrumentName = lineArgs[1];
    Note lowestNote = new Note(lineArgs[2]);
    Note highestNote = new Note(lineArgs[3]);

    switch (type) 
    {
        case "b": Brass brassInstrument = new Brass(instrumentName, null, lowestNote, highestNote);
            instruments.Add(brassInstrument);
            break;
        case "c": Chordophone chordophoneInstrument = new Chordophone(instrumentName, null, lowestNote, highestNote);
            instruments.Add((chordophoneInstrument));
            break;
        case "w": Woodwind windwoodInstrument = new Woodwind(instrumentName, null, lowestNote, highestNote);
            instruments.Add((windwoodInstrument));
            break;
    }
}

instruments.Sort((x, y) => string.Compare(x.Name, y.Name));

for (int i = 0; i < instruments.Count; i++)
{
    Console.WriteLine($"{i + 1}. {instruments[i]}");
}

string[] notesLine = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);

List<Note> noteList = new List<Note>();

foreach (string noteLine in notesLine) 
{
    Note note = new Note(noteLine[0].ToString(), noteLine[1], int.Parse(noteLine.Substring(2)));

    noteList.Add(note);
}

double length = noteList.Sum(n => n.Duration) / 10.0;

Console.WriteLine($"{length:f1}");

