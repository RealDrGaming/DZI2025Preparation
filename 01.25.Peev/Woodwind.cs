namespace _01._25.Peev;

public class Woodwind : Aerophone
{
    public Woodwind(string name, string kind, Note low, Note high) : base(name, kind, low, high)
    {
        subKind = nameof(Woodwind);
    }
}