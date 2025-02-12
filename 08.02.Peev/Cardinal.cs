namespace _08._02.Peev
{
    public class Cardinal : Churchman
    {
        private string superiorName;

        public Cardinal(string personName, string superiorName) : base("Cardinal", personName)
        {
            this.superiorName = superiorName;
        }
        public override string GetSuperiorName()
        {
            return superiorName;
        }
        public override string GetSuperiorClass()
        {
            return base.ClassName;
        }
    }
}