using System.Runtime.InteropServices;

namespace _01._25.Peev;

public class Note : IComparable<Note>
{
    public Note(string name, char octave, int dur)
    {
        this.Name = name;
        this.Octave = octave;
        this.Duration = dur;
    }

    public Note(string name) 
    {
        this.Name = name;
    }

    public string Name { get; private set; }
    public char Octave { get; private set; }
    public int Duration { get; private set; }

    private string values = "A Bb B C C# D D# E F F# G G#";

    public override string ToString()
    {
        return $"Note name - {Name}, Note octave - {Octave}, Note duration - {Duration}";
    }

    public int CompareTo(Note? other)
    {
        if (other == null) return 1;

        int nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
        if (nameComparison != 0) return nameComparison;

        int octaveComparison = Octave.CompareTo(other.Octave);
        if (octaveComparison != 0) return octaveComparison;

        return Duration.CompareTo(other.Duration);
    }
}