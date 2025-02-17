namespace DZI.Multiple
{
    public class ItemList
    {
        public ItemList() 
        {
            items = new List<Item>();
        }

        private List<Item> items;

        public int Count { get { return items.Count; } }

        public Item Get(int index) 
        {
            if (items[index] != null)
            {
                return items[index];
            }
            else
                throw new IndexOutOfRangeException("Item at that index does not exist!");
        }

        public void Add(Item item)
        {
            if (items.Contains(item))
            {
                throw new ArgumentException("Item is already in the collection!");
            }

            items.Add(item);
            items.Sort();
        }
    }
}
