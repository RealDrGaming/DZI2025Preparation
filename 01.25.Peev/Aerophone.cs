namespace _01._25.Peev;

public class Aerophone : Instrument
{
    public Aerophone(string name, string kind, Note low, Note high) : base(name, nameof(Aerophone), low, high)
    {

    }

    protected string subKind;

    public override string ToString()
    {
        return $"{Kind}, {subKind}:{Name}";
    }
}