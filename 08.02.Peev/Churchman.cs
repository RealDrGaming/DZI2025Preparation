namespace _08._02.Peev
{
    public abstract class Churchman
    {
        public Churchman(string className, string personName)
        {
            this.ClassName = className;
            this.PersonName = personName;
        }

        public string ClassName { get; protected set; }
        public string PersonName { get; private set; }

        abstract public string GetSuperiorClass();

        abstract public string GetSuperiorName();

        public override string ToString()
        {
            return $"{PersonName}: {ClassName} dependant on {GetSuperiorName()}";
        }
    }
}