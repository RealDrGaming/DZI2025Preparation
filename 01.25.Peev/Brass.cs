namespace _01._25.Peev;

public class Brass : Aerophone
{
    public Brass(string name, string kind, Note low, Note high) : base(name, kind, low, high)
    {
        subKind = nameof(Brass);
    }
}