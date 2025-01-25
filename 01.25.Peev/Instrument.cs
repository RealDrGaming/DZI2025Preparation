namespace _01._25.Peev;

public class Instrument
{
    public Instrument(string name, string kind, Note low, Note high) 
    {
        this.Name = name;
        this.Kind = kind;
        this.lowest = low;
        this.highest = high;
    }

    public string Name { get; private set; }
    public string Kind { get; private set; }

    private Note lowest;
    private Note highest;

    public Note GetLowest() 
    {
        return lowest;
    }

    public Note GetHighest()
    {
        return highest;
    }

    public override string ToString()
    {
        return $"{Kind}:{Name}";
    }
}