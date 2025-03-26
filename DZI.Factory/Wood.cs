using System.Text;

namespace DZI.Factory
{
    public class Wood
    {
        public Wood(string code, string name, double amountInCubic, int daysViable, char type, string comeInDate, string siloPosition, int? neededHumidity)
        {
            this.Code = code;
            this.Name = name;
            this.AmountInCubic = amountInCubic;
            this.DaysViable = daysViable;
            this.Type = type;
            this.ComeInDate = comeInDate;
            this.SiloPosition = siloPosition;
            this.NeededHumidity = neededHumidity;
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public double AmountInCubic { get; set; }
        public int DaysViable { get; set; }
        public char Type { get; set; }
        public string ComeInDate { get; set; }
        public string SiloPosition { get; set; }
        public int? NeededHumidity { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{SiloPosition}, {Code}, {Name}, {AmountInCubic}, {ComeInDate}, {DaysViable}");

            if (this.Type == 'E')
                sb.Append($", B%={NeededHumidity:f2}");

            return sb.ToString().Trim();
        }
    }
}