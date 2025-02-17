namespace DZI.Multiple
{
    public class Item : IComparable<Item>
    {
        public Item(string description, double price)
        {
            this.Description = description;
            this.Price = price;
        }

        private string description;

        public string Description
        {
            get => description;
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
                else
                    throw new ArgumentException("Argument for description cannot be null or empty!");
            }
        }

        private double price;
        public double Price
        {
            get => price;
            private set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                    throw new ArgumentException("Argument for price cannot be negative!");
            }
        }

        public override string ToString()
        {
            return $"{this.Description} ({this.Price:f2})";
        }

        public int CompareTo(Item? other)
        {
            if (this.Description.ToCharArray().Sum(c => ((short)c)) <= other.Description.ToCharArray().Sum(c => ((short)c))
                || this.Price <= other.Price)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}