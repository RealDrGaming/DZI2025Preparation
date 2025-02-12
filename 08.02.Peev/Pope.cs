namespace _08._02.Peev
{
    public class Pope : Churchman
    {
        public Pope(string personName) : base("Pope", personName)
        {
        }

        public override string GetSuperiorName()
        {
            return "";
        }
        public override string GetSuperiorClass()
        {
            return "";
        }

        public override string ToString()
        {
            return PersonName + ": " + ClassName;
        }
    }
}
